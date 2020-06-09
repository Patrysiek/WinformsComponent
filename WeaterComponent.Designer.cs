namespace WeatherApp
{
    partial class WeaterComponent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.historyList = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.weatherTable = new System.Windows.Forms.TableLayoutPanel();
            this.coordinatesButton = new System.Windows.Forms.Button();
            this.cityButton = new System.Windows.Forms.Button();
            this.dateButton = new System.Windows.Forms.Button();
            this.temperatureButton = new System.Windows.Forms.Button();
            this.pressureButton = new System.Windows.Forms.Button();
            this.humidityButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.sunTimesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.weatherTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.historyList);
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.weatherTable);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 502;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // historyList
            // 
            this.historyList.HideSelection = false;
            this.historyList.Location = new System.Drawing.Point(4, 7);
            this.historyList.Name = "historyList";
            this.historyList.Size = new System.Drawing.Size(495, 440);
            this.historyList.TabIndex = 1;
            this.historyList.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(495, 443);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.saveButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.clearButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 409);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 38);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(147, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(138, 32);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(3, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(138, 32);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // weatherTable
            // 
            this.weatherTable.ColumnCount = 1;
            this.weatherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.weatherTable.Controls.Add(this.coordinatesButton, 0, 2);
            this.weatherTable.Controls.Add(this.cityButton, 0, 3);
            this.weatherTable.Controls.Add(this.dateButton, 0, 4);
            this.weatherTable.Controls.Add(this.temperatureButton, 0, 5);
            this.weatherTable.Controls.Add(this.pressureButton, 0, 6);
            this.weatherTable.Controls.Add(this.humidityButton, 0, 7);
            this.weatherTable.Controls.Add(this.searchBox, 0, 0);
            this.weatherTable.Controls.Add(this.searchButton, 0, 1);
            this.weatherTable.Controls.Add(this.sunTimesButton, 0, 8);
            this.weatherTable.Location = new System.Drawing.Point(3, 4);
            this.weatherTable.Name = "weatherTable";
            this.weatherTable.RowCount = 9;
            this.weatherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.weatherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.weatherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.weatherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.weatherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.weatherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.weatherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.weatherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.weatherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.weatherTable.Size = new System.Drawing.Size(294, 398);
            this.weatherTable.TabIndex = 0;
            // 
            // coordinatesButton
            // 
            this.coordinatesButton.Location = new System.Drawing.Point(3, 89);
            this.coordinatesButton.Name = "coordinatesButton";
            this.coordinatesButton.Size = new System.Drawing.Size(288, 35);
            this.coordinatesButton.TabIndex = 8;
            this.coordinatesButton.Text = "Coordinates";
            this.coordinatesButton.UseVisualStyleBackColor = true;
            // 
            // cityButton
            // 
            this.cityButton.Location = new System.Drawing.Point(3, 132);
            this.cityButton.Name = "cityButton";
            this.cityButton.Size = new System.Drawing.Size(288, 35);
            this.cityButton.TabIndex = 2;
            this.cityButton.Text = "City";
            this.cityButton.UseVisualStyleBackColor = true;
            // 
            // dateButton
            // 
            this.dateButton.Location = new System.Drawing.Point(3, 175);
            this.dateButton.Name = "dateButton";
            this.dateButton.Size = new System.Drawing.Size(288, 33);
            this.dateButton.TabIndex = 3;
            this.dateButton.Text = "Date";
            this.dateButton.UseVisualStyleBackColor = true;
            // 
            // temperatureButton
            // 
            this.temperatureButton.Location = new System.Drawing.Point(3, 218);
            this.temperatureButton.Name = "temperatureButton";
            this.temperatureButton.Size = new System.Drawing.Size(288, 33);
            this.temperatureButton.TabIndex = 4;
            this.temperatureButton.Text = "Temperature";
            this.temperatureButton.UseVisualStyleBackColor = true;
            // 
            // pressureButton
            // 
            this.pressureButton.Location = new System.Drawing.Point(3, 261);
            this.pressureButton.Name = "pressureButton";
            this.pressureButton.Size = new System.Drawing.Size(288, 33);
            this.pressureButton.TabIndex = 5;
            this.pressureButton.Text = "Pressure";
            this.pressureButton.UseVisualStyleBackColor = true;
            // 
            // humidityButton
            // 
            this.humidityButton.Location = new System.Drawing.Point(3, 304);
            this.humidityButton.Name = "humidityButton";
            this.humidityButton.Size = new System.Drawing.Size(288, 33);
            this.humidityButton.TabIndex = 6;
            this.humidityButton.Text = "Humidity";
            this.humidityButton.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(3, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(288, 35);
            this.searchBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(3, 46);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(288, 37);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // sunTimesButton
            // 
            this.sunTimesButton.Location = new System.Drawing.Point(3, 347);
            this.sunTimesButton.Name = "sunTimesButton";
            this.sunTimesButton.Size = new System.Drawing.Size(288, 35);
            this.sunTimesButton.TabIndex = 7;
            this.sunTimesButton.Text = "Sunrise and Sunset";
            this.sunTimesButton.UseVisualStyleBackColor = true;
            // 
            // WeaterApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "WeaterApp";
            this.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.weatherTable.ResumeLayout(false);
            this.weatherTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TableLayoutPanel weatherTable;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cityButton;
        private System.Windows.Forms.Button dateButton;
        private System.Windows.Forms.Button temperatureButton;
        private System.Windows.Forms.Button pressureButton;
        private System.Windows.Forms.Button sunTimesButton;
        private System.Windows.Forms.Button humidityButton;
        private System.Windows.Forms.ListView historyList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button coordinatesButton;
    }
}
