/*
 * Сделано в SharpDevelop.
 * Пользователь: user
 * Дата: 31.10.2019
 * Время: 15:01
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace helper
{
	partial class Spravka
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Name_Program = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Name_Program
			// 
			this.Name_Program.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name_Program.Location = new System.Drawing.Point(12, 9);
			this.Name_Program.Name = "Name_Program";
			this.Name_Program.Size = new System.Drawing.Size(210, 41);
			this.Name_Program.TabIndex = 0;
			this.Name_Program.Text = "Transleid: оффлайн словарь                   для ЭВМ";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 187);
			this.label1.TabIndex = 1;
			this.label1.Text = "Программа \"Transleid: оффлайн словарь \" предназначена для перевода текста/файлов " +
			"до 4 гб \r\n\r\nИcполнители: Лазукин Егор Романович\r\n\r\nCоисполнители: тестировщики L" +
			"olzteam\r\n\r\nVersion: 1.0.0 ";
			// 
			// Spravka
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(231, 246);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Name_Program);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Spravka";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Name_Program;
	}
}
