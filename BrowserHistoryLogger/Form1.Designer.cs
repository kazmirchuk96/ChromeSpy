
namespace BrowserHistoryLogger
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.chromeDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chromeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // chromeDataGrid
            // 
            this.chromeDataGrid.AllowUserToAddRows = false;
            this.chromeDataGrid.AllowUserToDeleteRows = false;
            this.chromeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chromeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chromeDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeDataGrid.Location = new System.Drawing.Point(0, 0);
            this.chromeDataGrid.Name = "chromeDataGrid";
            this.chromeDataGrid.RowHeadersVisible = false;
            this.chromeDataGrid.RowHeadersWidth = 51;
            this.chromeDataGrid.RowTemplate.Height = 24;
            this.chromeDataGrid.Size = new System.Drawing.Size(1146, 717);
            this.chromeDataGrid.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 717);
            this.Controls.Add(this.chromeDataGrid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chromeDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView chromeDataGrid;
    }
}

