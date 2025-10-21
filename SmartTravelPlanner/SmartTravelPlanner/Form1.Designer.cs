namespace SmartTravelPlanner
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_title = new Label();
            btn_load_map = new Button();
            grp_traveler_info = new GroupBox();
            label_traveler_name = new Label();
            input_traveler_name = new TextBox();
            label_current_location = new Label();
            input_current_location = new TextBox();
            btn_create_traveler = new Button();
            btn_load_traveler = new Button();
            btn_save_traveler = new Button();
            grp_path_finding = new GroupBox();
            btn_clearRoute = new Button();
            label_from = new Label();
            label_from_value = new Label();
            label_to = new Label();
            input_destination = new TextBox();
            btn_plan_route = new Button();
            label_distance = new Label();
            grp_current_route = new GroupBox();
            input_route_display = new TextBox();
            label_total_stops = new Label();
            btn_exit = new Button();
            label_map_status = new Label();
            label2 = new Label();
            grp_available_cities = new GroupBox();
            list_available_cities = new ListBox();
            label_cities_count = new Label();
            grp_traveler_info.SuspendLayout();
            grp_path_finding.SuspendLayout();
            grp_current_route.SuspendLayout();
            grp_available_cities.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_title.ForeColor = Color.White;
            lbl_title.Location = new Point(50, 28);
            lbl_title.Margin = new Padding(4, 0, 4, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(258, 48);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Travel Planner";
            // 
            // btn_load_map
            // 
            btn_load_map.BackColor = Color.FromArgb(102, 126, 234);
            btn_load_map.FlatStyle = FlatStyle.Flat;
            btn_load_map.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_load_map.ForeColor = Color.White;
            btn_load_map.Location = new Point(214, 92);
            btn_load_map.Margin = new Padding(4, 6, 4, 6);
            btn_load_map.Name = "btn_load_map";
            btn_load_map.Size = new Size(177, 63);
            btn_load_map.TabIndex = 1;
            btn_load_map.Text = "Load Map";
            btn_load_map.UseVisualStyleBackColor = false;
            btn_load_map.Click += btn_load_map_Click;
            // 
            // grp_traveler_info
            // 
            grp_traveler_info.BackColor = Color.FromArgb(248, 249, 250);
            grp_traveler_info.Controls.Add(label_traveler_name);
            grp_traveler_info.Controls.Add(input_traveler_name);
            grp_traveler_info.Controls.Add(label_current_location);
            grp_traveler_info.Controls.Add(input_current_location);
            grp_traveler_info.Controls.Add(btn_create_traveler);
            grp_traveler_info.Controls.Add(btn_load_traveler);
            grp_traveler_info.Controls.Add(btn_save_traveler);
            grp_traveler_info.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grp_traveler_info.Location = new Point(50, 182);
            grp_traveler_info.Margin = new Padding(4, 6, 4, 6);
            grp_traveler_info.Name = "grp_traveler_info";
            grp_traveler_info.Padding = new Padding(4, 6, 4, 6);
            grp_traveler_info.Size = new Size(434, 422);
            grp_traveler_info.TabIndex = 2;
            grp_traveler_info.TabStop = false;
            grp_traveler_info.Text = "Traveler Info";
            // 
            // label_traveler_name
            // 
            label_traveler_name.AutoSize = true;
            label_traveler_name.Font = new Font("Segoe UI", 9F);
            label_traveler_name.Location = new Point(24, 58);
            label_traveler_name.Margin = new Padding(4, 0, 4, 0);
            label_traveler_name.Name = "label_traveler_name";
            label_traveler_name.Size = new Size(123, 25);
            label_traveler_name.TabIndex = 0;
            label_traveler_name.Text = "Traveler Name";
            // 
            // input_traveler_name
            // 
            input_traveler_name.Font = new Font("Segoe UI", 10F);
            input_traveler_name.Location = new Point(24, 96);
            input_traveler_name.Margin = new Padding(4, 6, 4, 6);
            input_traveler_name.Name = "input_traveler_name";
            input_traveler_name.Size = new Size(383, 34);
            input_traveler_name.TabIndex = 1;
            // 
            // label_current_location
            // 
            label_current_location.AutoSize = true;
            label_current_location.Font = new Font("Segoe UI", 9F);
            label_current_location.Location = new Point(24, 164);
            label_current_location.Margin = new Padding(4, 0, 4, 0);
            label_current_location.Name = "label_current_location";
            label_current_location.Size = new Size(142, 25);
            label_current_location.TabIndex = 2;
            label_current_location.Text = "Current Location";
            // 
            // input_current_location
            // 
            input_current_location.Font = new Font("Segoe UI", 10F);
            input_current_location.Location = new Point(24, 202);
            input_current_location.Margin = new Padding(4, 6, 4, 6);
            input_current_location.Name = "input_current_location";
            input_current_location.Size = new Size(383, 34);
            input_current_location.TabIndex = 3;
            // 
            // btn_create_traveler
            // 
            btn_create_traveler.BackColor = Color.FromArgb(102, 126, 234);
            btn_create_traveler.FlatStyle = FlatStyle.Flat;
            btn_create_traveler.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_create_traveler.ForeColor = Color.White;
            btn_create_traveler.Location = new Point(22, 266);
            btn_create_traveler.Margin = new Padding(4, 6, 4, 6);
            btn_create_traveler.Name = "btn_create_traveler";
            btn_create_traveler.Size = new Size(383, 58);
            btn_create_traveler.TabIndex = 4;
            btn_create_traveler.Text = "Create Traveler";
            btn_create_traveler.UseVisualStyleBackColor = false;
            btn_create_traveler.Click += btn_create_traveler_Click;
            // 
            // btn_load_traveler
            // 
            btn_load_traveler.BackColor = Color.White;
            btn_load_traveler.FlatStyle = FlatStyle.Flat;
            btn_load_traveler.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_load_traveler.ForeColor = Color.FromArgb(102, 126, 234);
            btn_load_traveler.Location = new Point(24, 333);
            btn_load_traveler.Margin = new Padding(4, 6, 4, 6);
            btn_load_traveler.Name = "btn_load_traveler";
            btn_load_traveler.Size = new Size(184, 58);
            btn_load_traveler.TabIndex = 5;
            btn_load_traveler.Text = "Load Traveler";
            btn_load_traveler.UseVisualStyleBackColor = false;
            btn_load_traveler.Click += btn_load_traveler_Click;
            // 
            // btn_save_traveler
            // 
            btn_save_traveler.BackColor = Color.White;
            btn_save_traveler.FlatStyle = FlatStyle.Flat;
            btn_save_traveler.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_save_traveler.ForeColor = Color.FromArgb(102, 126, 234);
            btn_save_traveler.Location = new Point(221, 333);
            btn_save_traveler.Margin = new Padding(4, 6, 4, 6);
            btn_save_traveler.Name = "btn_save_traveler";
            btn_save_traveler.Size = new Size(184, 58);
            btn_save_traveler.TabIndex = 6;
            btn_save_traveler.Text = "Save Traveler";
            btn_save_traveler.UseVisualStyleBackColor = false;
            btn_save_traveler.Click += btn_save_traveler_Click;
            // 
            // grp_path_finding
            // 
            grp_path_finding.BackColor = Color.FromArgb(248, 249, 250);
            grp_path_finding.Controls.Add(btn_clearRoute);
            grp_path_finding.Controls.Add(label_from);
            grp_path_finding.Controls.Add(label_from_value);
            grp_path_finding.Controls.Add(label_to);
            grp_path_finding.Controls.Add(input_destination);
            grp_path_finding.Controls.Add(btn_plan_route);
            grp_path_finding.Controls.Add(label_distance);
            grp_path_finding.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grp_path_finding.Location = new Point(508, 182);
            grp_path_finding.Margin = new Padding(4, 6, 4, 6);
            grp_path_finding.Name = "grp_path_finding";
            grp_path_finding.Padding = new Padding(4, 6, 4, 6);
            grp_path_finding.Size = new Size(429, 422);
            grp_path_finding.TabIndex = 4;
            grp_path_finding.TabStop = false;
            grp_path_finding.Text = "Find Shortest Path";
            // 
            // btn_clearRoute
            // 
            btn_clearRoute.BackColor = Color.White;
            btn_clearRoute.FlatStyle = FlatStyle.Flat;
            btn_clearRoute.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_clearRoute.ForeColor = Color.FromArgb(102, 126, 234);
            btn_clearRoute.Location = new Point(220, 266);
            btn_clearRoute.Margin = new Padding(4, 6, 4, 6);
            btn_clearRoute.Name = "btn_clearRoute";
            btn_clearRoute.Size = new Size(184, 58);
            btn_clearRoute.TabIndex = 6;
            btn_clearRoute.Text = "Clear Route";
            btn_clearRoute.UseVisualStyleBackColor = false;
            btn_clearRoute.Click += btn_clearRoute_Click;
            // 
            // label_from
            // 
            label_from.AutoSize = true;
            label_from.Font = new Font("Segoe UI", 9F);
            label_from.Location = new Point(24, 58);
            label_from.Margin = new Padding(4, 0, 4, 0);
            label_from.Name = "label_from";
            label_from.Size = new Size(199, 25);
            label_from.TabIndex = 0;
            label_from.Text = "From (Current Location)";
            // 
            // label_from_value
            // 
            label_from_value.BackColor = Color.White;
            label_from_value.BorderStyle = BorderStyle.FixedSingle;
            label_from_value.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label_from_value.ForeColor = Color.FromArgb(102, 126, 234);
            label_from_value.Location = new Point(24, 96);
            label_from_value.Margin = new Padding(4, 0, 4, 0);
            label_from_value.Name = "label_from_value";
            label_from_value.Size = new Size(380, 34);
            label_from_value.TabIndex = 1;
            label_from_value.Text = "Not Set";
            label_from_value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_to
            // 
            label_to.AutoSize = true;
            label_to.Font = new Font("Segoe UI", 9F);
            label_to.Location = new Point(24, 164);
            label_to.Margin = new Padding(4, 0, 4, 0);
            label_to.Name = "label_to";
            label_to.Size = new Size(30, 25);
            label_to.TabIndex = 2;
            label_to.Text = "To";
            // 
            // input_destination
            // 
            input_destination.Font = new Font("Segoe UI", 10F);
            input_destination.Location = new Point(24, 202);
            input_destination.Margin = new Padding(4, 6, 4, 6);
            input_destination.Name = "input_destination";
            input_destination.Size = new Size(380, 34);
            input_destination.TabIndex = 3;
            // 
            // btn_plan_route
            // 
            btn_plan_route.BackColor = Color.FromArgb(102, 126, 234);
            btn_plan_route.FlatStyle = FlatStyle.Flat;
            btn_plan_route.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_plan_route.ForeColor = Color.White;
            btn_plan_route.Location = new Point(24, 266);
            btn_plan_route.Margin = new Padding(4, 6, 4, 6);
            btn_plan_route.Name = "btn_plan_route";
            btn_plan_route.Size = new Size(184, 58);
            btn_plan_route.TabIndex = 4;
            btn_plan_route.Text = "Plan Route";
            btn_plan_route.UseVisualStyleBackColor = false;
            btn_plan_route.Click += btn_plan_route_Click;
            // 
            // label_distance
            // 
            label_distance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label_distance.ForeColor = Color.FromArgb(102, 126, 234);
            label_distance.Location = new Point(24, 333);
            label_distance.Margin = new Padding(4, 0, 4, 0);
            label_distance.Name = "label_distance";
            label_distance.Size = new Size(380, 48);
            label_distance.TabIndex = 5;
            label_distance.Text = "Distance: 0 km";
            label_distance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grp_current_route
            // 
            grp_current_route.BackColor = Color.FromArgb(248, 249, 250);
            grp_current_route.Controls.Add(input_route_display);
            grp_current_route.Controls.Add(label_total_stops);
            grp_current_route.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grp_current_route.Location = new Point(508, 625);
            grp_current_route.Margin = new Padding(4, 6, 4, 6);
            grp_current_route.Name = "grp_current_route";
            grp_current_route.Padding = new Padding(4, 6, 4, 6);
            grp_current_route.Size = new Size(429, 364);
            grp_current_route.TabIndex = 5;
            grp_current_route.TabStop = false;
            grp_current_route.Text = "Current Route";
            // 
            // input_route_display
            // 
            input_route_display.BackColor = Color.White;
            input_route_display.BorderStyle = BorderStyle.FixedSingle;
            input_route_display.Font = new Font("Segoe UI", 10F);
            input_route_display.Location = new Point(24, 58);
            input_route_display.Margin = new Padding(4, 6, 4, 6);
            input_route_display.Multiline = true;
            input_route_display.Name = "input_route_display";
            input_route_display.ReadOnly = true;
            input_route_display.ScrollBars = ScrollBars.Vertical;
            input_route_display.Size = new Size(380, 254);
            input_route_display.TabIndex = 0;
            input_route_display.Text = "No route planned";
            // 
            // label_total_stops
            // 
            label_total_stops.Font = new Font("Segoe UI", 9F);
            label_total_stops.ForeColor = Color.FromArgb(100, 100, 100);
            label_total_stops.Location = new Point(24, 321);
            label_total_stops.Margin = new Padding(4, 0, 4, 0);
            label_total_stops.Name = "label_total_stops";
            label_total_stops.Size = new Size(405, 28);
            label_total_stops.TabIndex = 1;
            label_total_stops.Text = "Total stops: 0";
            label_total_stops.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(220, 53, 69);
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(873, 28);
            btn_exit.Margin = new Padding(4, 6, 4, 6);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(68, 48);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // label_map_status
            // 
            label_map_status.AutoSize = true;
            label_map_status.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_map_status.ForeColor = Color.DarkOrange;
            label_map_status.ImageAlign = ContentAlignment.MiddleRight;
            label_map_status.Location = new Point(50, 127);
            label_map_status.Margin = new Padding(4, 0, 4, 0);
            label_map_status.Name = "label_map_status";
            label_map_status.Size = new Size(108, 28);
            label_map_status.TabIndex = 9;
            label_map_status.Text = "not loaded";
            label_map_status.TextAlign = ContentAlignment.MiddleRight;
            label_map_status.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 10;
            label2.Text = "Map load status:";
            // 
            // grp_available_cities
            // 
            grp_available_cities.BackColor = Color.FromArgb(248, 249, 250);
            grp_available_cities.Controls.Add(list_available_cities);
            grp_available_cities.Controls.Add(label_cities_count);
            grp_available_cities.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grp_available_cities.Location = new Point(50, 625);
            grp_available_cities.Name = "grp_available_cities";
            grp_available_cities.Size = new Size(434, 364);
            grp_available_cities.TabIndex = 6;
            grp_available_cities.TabStop = false;
            grp_available_cities.Text = "Available Destinations";
            // 
            // list_available_cities
            // 
            list_available_cities.BackColor = Color.White;
            list_available_cities.BorderStyle = BorderStyle.FixedSingle;
            list_available_cities.Font = new Font("Segoe UI", 10F);
            list_available_cities.ItemHeight = 28;
            list_available_cities.Location = new Point(22, 58);
            list_available_cities.Name = "list_available_cities";
            list_available_cities.Size = new Size(383, 254);
            list_available_cities.Sorted = true;
            list_available_cities.TabIndex = 0;
            list_available_cities.SelectedIndexChanged += List_available_cities_Click;
            // 
            // label_cities_count
            // 
            label_cities_count.Font = new Font("Segoe UI", 9F);
            label_cities_count.ForeColor = Color.FromArgb(100, 100, 100);
            label_cities_count.Location = new Point(22, 318);
            label_cities_count.Name = "label_cities_count";
            label_cities_count.Size = new Size(383, 35);
            label_cities_count.TabIndex = 1;
            label_cities_count.Text = "Total cities: 0";
            label_cities_count.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(102, 126, 234);
            ClientSize = new Size(971, 1044);
            Controls.Add(label2);
            Controls.Add(label_map_status);
            Controls.Add(btn_exit);
            Controls.Add(grp_current_route);
            Controls.Add(grp_path_finding);
            Controls.Add(grp_traveler_info);
            Controls.Add(btn_load_map);
            Controls.Add(lbl_title);
            Controls.Add(grp_available_cities);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            Name = "Form1";
            Padding = new Padding(0, 0, 30, 30);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Travel Planner";
            grp_traveler_info.ResumeLayout(false);
            grp_traveler_info.PerformLayout();
            grp_path_finding.ResumeLayout(false);
            grp_path_finding.PerformLayout();
            grp_current_route.ResumeLayout(false);
            grp_current_route.PerformLayout();
            grp_available_cities.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_load_map;

        private System.Windows.Forms.GroupBox grp_available_cities;
        private System.Windows.Forms.ListBox list_available_cities;
        private System.Windows.Forms.Label label_cities_count;

        private System.Windows.Forms.GroupBox grp_traveler_info;
        private System.Windows.Forms.Label label_traveler_name;
        private System.Windows.Forms.TextBox input_traveler_name;
        private System.Windows.Forms.Label label_current_location;
        private System.Windows.Forms.TextBox input_current_location;
        private System.Windows.Forms.Button btn_create_traveler;
        private System.Windows.Forms.Button btn_load_traveler;
        private System.Windows.Forms.Button btn_save_traveler;

        private System.Windows.Forms.GroupBox grp_path_finding;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_from_value;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.TextBox input_destination;
        private System.Windows.Forms.Button btn_plan_route;
        private System.Windows.Forms.Label label_distance;

        private System.Windows.Forms.GroupBox grp_current_route;
        private System.Windows.Forms.TextBox input_route_display;
        private System.Windows.Forms.Label label_total_stops;
        private System.Windows.Forms.Button btn_exit;
        private Label label_map_status;
        private Label label2;
        private Button btn_clearRoute;
    }
}

