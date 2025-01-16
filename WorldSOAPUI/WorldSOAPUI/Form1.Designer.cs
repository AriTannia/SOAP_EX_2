namespace WorldSOAPUI
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCountryCode = new System.Windows.Forms.Label();
            this.textBoxCountryCode = new System.Windows.Forms.TextBox();
            this.buttonGetAllCountries = new System.Windows.Forms.Button();
            this.buttonGetCountryByCode = new System.Windows.Forms.Button();
            this.buttonGetPopulationByCountryCode = new System.Windows.Forms.Button();
            this.buttonGetCityByName = new System.Windows.Forms.Button();
            this.textBoxCityName = new System.Windows.Forms.TextBox();
            this.labelCityName = new System.Windows.Forms.Label();
            this.buttonGetCitiesByCountry = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(253, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Country and City Info";
            // 
            // labelCountryCode
            // 
            this.labelCountryCode.AutoSize = true;
            this.labelCountryCode.Location = new System.Drawing.Point(14, 50);
            this.labelCountryCode.Name = "labelCountryCode";
            this.labelCountryCode.Size = new System.Drawing.Size(91, 16);
            this.labelCountryCode.TabIndex = 1;
            this.labelCountryCode.Text = "Country Code:";
            // 
            // textBoxCountryCode
            // 
            this.textBoxCountryCode.Location = new System.Drawing.Point(113, 47);
            this.textBoxCountryCode.Name = "textBoxCountryCode";
            this.textBoxCountryCode.Size = new System.Drawing.Size(100, 22);
            this.textBoxCountryCode.TabIndex = 2;
            // 
            // buttonGetAllCountries
            // 
            this.buttonGetAllCountries.Location = new System.Drawing.Point(17, 90);
            this.buttonGetAllCountries.Name = "buttonGetAllCountries";
            this.buttonGetAllCountries.Size = new System.Drawing.Size(150, 30);
            this.buttonGetAllCountries.TabIndex = 3;
            this.buttonGetAllCountries.Text = "Get All Countries";
            this.buttonGetAllCountries.UseVisualStyleBackColor = true;
            this.buttonGetAllCountries.Click += new System.EventHandler(this.buttonGetAllCountries_Click);
            // 
            // buttonGetCountryByCode
            // 
            this.buttonGetCountryByCode.Location = new System.Drawing.Point(220, 45);
            this.buttonGetCountryByCode.Name = "buttonGetCountryByCode";
            this.buttonGetCountryByCode.Size = new System.Drawing.Size(150, 30);
            this.buttonGetCountryByCode.TabIndex = 4;
            this.buttonGetCountryByCode.Text = "Get Country Info";
            this.buttonGetCountryByCode.UseVisualStyleBackColor = true;
            this.buttonGetCountryByCode.Click += new System.EventHandler(this.buttonGetCountryByCode_Click);
            // 
            // buttonGetPopulationByCountryCode
            // 
            this.buttonGetPopulationByCountryCode.Location = new System.Drawing.Point(380, 45);
            this.buttonGetPopulationByCountryCode.Name = "buttonGetPopulationByCountryCode";
            this.buttonGetPopulationByCountryCode.Size = new System.Drawing.Size(150, 30);
            this.buttonGetPopulationByCountryCode.TabIndex = 5;
            this.buttonGetPopulationByCountryCode.Text = "Get Population";
            this.buttonGetPopulationByCountryCode.UseVisualStyleBackColor = true;
            this.buttonGetPopulationByCountryCode.Click += new System.EventHandler(this.buttonGetPopulationByCountryCode_Click);
            // 
            // buttonGetCityByName
            // 
            this.buttonGetCityByName.Location = new System.Drawing.Point(220, 140);
            this.buttonGetCityByName.Name = "buttonGetCityByName";
            this.buttonGetCityByName.Size = new System.Drawing.Size(150, 30);
            this.buttonGetCityByName.TabIndex = 6;
            this.buttonGetCityByName.Text = "Get City by Name";
            this.buttonGetCityByName.UseVisualStyleBackColor = true;
            this.buttonGetCityByName.Click += new System.EventHandler(this.buttonGetCityByName_Click);
            // 
            // textBoxCityName
            // 
            this.textBoxCityName.Location = new System.Drawing.Point(113, 145);
            this.textBoxCityName.Name = "textBoxCityName";
            this.textBoxCityName.Size = new System.Drawing.Size(100, 22);
            this.textBoxCityName.TabIndex = 7;
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.Location = new System.Drawing.Point(14, 148);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(72, 16);
            this.labelCityName.TabIndex = 8;
            this.labelCityName.Text = "City Name:";
            // 
            // buttonGetCitiesByCountry
            // 
            this.buttonGetCitiesByCountry.Location = new System.Drawing.Point(545, 45);
            this.buttonGetCitiesByCountry.Name = "buttonGetCitiesByCountry";
            this.buttonGetCitiesByCountry.Size = new System.Drawing.Size(150, 30);
            this.buttonGetCitiesByCountry.TabIndex = 9;
            this.buttonGetCitiesByCountry.Text = "Get Cities by Country";
            this.buttonGetCitiesByCountry.UseVisualStyleBackColor = true;
            this.buttonGetCitiesByCountry.Click += new System.EventHandler(this.buttonGetCitiesByCountry_Click);
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(17, 192);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersWidth = 51;
            this.dataGridViewResults.RowTemplate.Height = 24;
            this.dataGridViewResults.Size = new System.Drawing.Size(692, 219);
            this.dataGridViewResults.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 431);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.buttonGetCitiesByCountry);
            this.Controls.Add(this.buttonGetCityByName);
            this.Controls.Add(this.textBoxCityName);
            this.Controls.Add(this.labelCityName);
            this.Controls.Add(this.buttonGetPopulationByCountryCode);
            this.Controls.Add(this.buttonGetCountryByCode);
            this.Controls.Add(this.buttonGetAllCountries);
            this.Controls.Add(this.textBoxCountryCode);
            this.Controls.Add(this.labelCountryCode);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Country and City Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxCountryCode;
        private System.Windows.Forms.Label labelCountryCode;
        private System.Windows.Forms.Button buttonGetAllCountries;
        private System.Windows.Forms.Button buttonGetCountryByCode;
        private System.Windows.Forms.Button buttonGetPopulationByCountryCode;
        private System.Windows.Forms.Button buttonGetCityByName;
        private System.Windows.Forms.TextBox textBoxCityName;
        private System.Windows.Forms.Label labelCityName;
        private System.Windows.Forms.Button buttonGetCitiesByCountry;
        private System.Windows.Forms.DataGridView dataGridViewResults;

    }
}

