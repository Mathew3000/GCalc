using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCalc
{
    public partial class Form1 : Form
    {
        // Path to scan
        string path_scan = "";
        // Whether or not to scan subdirectories
        bool scan_sub = false;
        // Filament length
        double fi_length = 0.0;
        // Filament weight
        double fi_weight = 0.0;
        // Filament cost
        double fi_cost = 0.0;
        // Print duration
        double time_s = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_path_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd_start.ShowDialog();
            if (result == DialogResult.OK)
            {
                path_scan = fbd_start.SelectedPath;
                tb_path.Text = path_scan;
            }
        }

        private void cb_subdir_CheckedChanged(object sender, EventArgs e)
        {
            scan_sub = cb_subdir.Checked;
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            lb_files.Items.Clear();
        }

        private void bt_scan_Click(object sender, EventArgs e)
        {
            if(path_scan == "")
            {
                return;
            }

            SearchOption so;
            if(scan_sub)
            {
                so = SearchOption.AllDirectories;
            }
            else
            {
                so = SearchOption.TopDirectoryOnly;
            }
            string[] files = Directory.GetFiles(path_scan, "*.gcode", so);

            foreach (string file in files)
            {
                lb_files.Items.Add(file);
            }
        }

        private void bt_calc_Click(object sender, EventArgs e)
        {
            if(lb_files.Items.Count == 0)
            {
                return;
            }

            fi_cost = 0.0;
            fi_length = 0.0;
            fi_weight = 0.0;
            time_s = 0.0;

            double tmp_h = 0;
            double tmp_m = 0;
            double tmp_s = 0;

            int file_nr = 0;

            MessageBox.Show("Warning! For large file counts (or large files) this may need lots of RAM!", "Warning!");

            foreach(string file in lb_files.Items)
            {
                int line_nr = 0;
                int found_lines = 0;
                bool first_match = true;
                // The regex strings
                string pat_length = @"; filament used = \s*([^m\n\r]*)";
                string pat_cost = @"; filament cost = \s*([^m\n\r]*)";
                string pat_time = @"; estimated printing time =\s*([^hms]*)h*m*\s*([^ms]*)m*s*\s*([^s\n\r]*)";

                // This is a BIG BUFFER if you have a BIG FILE
                string[] lines = File.ReadAllLines(file);
                Array.Reverse(lines);
                
                // Iterate through all lines... this may take a while sorry
                foreach (string line in lines)
                {
                    // Set progress
                    line_nr++;

                    // Create regex
                    Regex rgx_len = new Regex(pat_length, RegexOptions.IgnoreCase);
                    Regex rgx_cost = new Regex(pat_cost, RegexOptions.IgnoreCase);
                    Regex rgx_time = new Regex(pat_time, RegexOptions.IgnoreCase);

                    // Match length
                    MatchCollection matches_len = rgx_len.Matches(line);
                    // Match cost
                    MatchCollection matches_cost = rgx_cost.Matches(line);
                    // Match time
                    MatchCollection matches_time = rgx_time.Matches(line);

                    // Check Matches for length
                    if (matches_len.Count > 0)
                    {
                        if (first_match)
                        {
                            fi_weight += double.Parse(matches_len[0].Groups[1].Value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                        }
                        else
                        {
                            fi_length += double.Parse(matches_len[0].Groups[1].Value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                        }
                        first_match = false;
                        found_lines++;
                    }
                    // Check Matches for cost
                    else if (matches_cost.Count > 0)
                    {
                        fi_cost += double.Parse(matches_cost[0].Groups[1].Value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                        found_lines++;
                    }
                    // Check Matches for time
                    else if (matches_time.Count > 0)
                    {
                        if (matches_time[0].Groups[3].Value != "")
                        {
                            tmp_h += double.Parse(matches_time[0].Groups[1].Value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                            tmp_m += double.Parse(matches_time[0].Groups[2].Value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                            tmp_s += double.Parse(matches_time[0].Groups[3].Value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                        }
                        else if (matches_time[0].Groups[2].Value != "")
                        {
                            tmp_m += double.Parse(matches_time[0].Groups[1].Value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                            tmp_s += double.Parse(matches_time[0].Groups[2].Value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                        }
                        else
                        {
                            tmp_s += double.Parse(matches_time[0].Groups[1].Value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                        }
                        found_lines++;
                    }

                    if(found_lines >= 4)
                    {
                        break;
                    }
                }

            }
            // Set labels
            lb_mm.Text = "mm";
            lb_g.Text = "g";

            // Set texts
            tb_length.Text = fi_length.ToString();
            tb_weight.Text = fi_weight.ToString();
            tb_cost.Text = fi_cost.ToString();
            // Calculate time
            tmp_m += Math.Floor(tmp_s / 60.0);
            tmp_s = tmp_s % 60.0; // Now we have our seconds
            tmp_h += Math.Floor(tmp_m / 60.0);
            tmp_m = tmp_m % 60.0; // How we have minutes and hours

            tb_h.Text = tmp_h.ToString();
            tb_m.Text = tmp_m.ToString();
            tb_s.Text = tmp_s.ToString();

            // Set progressbar
            file_nr++;

            GC.Collect();
            GC.WaitForPendingFinalizers();

        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            path_scan = tb_path.Text;
        }

        private void lb_mm_Click(object sender, EventArgs e)
        {
            if (lb_mm.Text == "mm")
            {
                lb_mm.Text = "cm";
                tb_length.Text = (fi_length / 10).ToString();
            }
            else if (lb_mm.Text == "cm")
            {
                lb_mm.Text = "m";
                tb_length.Text = (fi_length / 1000).ToString();
            }
            else
            {
                lb_mm.Text = "mm";
                tb_length.Text = (fi_length).ToString();
            }
        }

        private void lb_g_Click(object sender, EventArgs e)
        {
            if (lb_g.Text == "g")
            {
                lb_g.Text = "kg";
                tb_weight.Text = (fi_weight / 1000).ToString();
            }
            else
            {
                lb_g.Text = "g";
                tb_weight.Text = (fi_weight).ToString();
            }
        }
    }
}
