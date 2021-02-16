
namespace Csharp_2021_6._2_DatumUndUhrzeit
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.datDatum = new System.Windows.Forms.DateTimePicker();
			this.datUhrzeit = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// datDatum
			// 
			this.datDatum.Location = new System.Drawing.Point(12, 12);
			this.datDatum.Name = "datDatum";
			this.datDatum.Size = new System.Drawing.Size(200, 20);
			this.datDatum.TabIndex = 0;
			this.datDatum.ValueChanged += new System.EventHandler(this.datDatum_ValueChanged);
			// 
			// datUhrzeit
			// 
			this.datUhrzeit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.datUhrzeit.Location = new System.Drawing.Point(12, 38);
			this.datUhrzeit.Name = "datUhrzeit";
			this.datUhrzeit.ShowUpDown = true;
			this.datUhrzeit.Size = new System.Drawing.Size(200, 20);
			this.datUhrzeit.TabIndex = 1;
			this.datUhrzeit.ValueChanged += new System.EventHandler(this.datUhrzeit_ValueChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 202);
			this.Controls.Add(this.datUhrzeit);
			this.Controls.Add(this.datDatum);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker datDatum;
		private System.Windows.Forms.DateTimePicker datUhrzeit;
	}
}

