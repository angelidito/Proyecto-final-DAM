
namespace Conoce_tu_ukelele.Forms
{
	partial class Inicio
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
			this.MenuTitulo = new System.Windows.Forms.MenuStrip();
			this.label1 = new System.Windows.Forms.Label();
			this.Menu = new System.Windows.Forms.MenuStrip();
			this.MenuItemAcordes = new FontAwesome.Sharp.IconMenuItem();
			this.MenuItemEscalas = new FontAwesome.Sharp.IconMenuItem();
			this.MenuItemAfinacion = new FontAwesome.Sharp.IconMenuItem();
			this.salirbtn = new FontAwesome.Sharp.IconMenuItem();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.contenedor = new System.Windows.Forms.Panel();
			this.Menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MenuTitulo
			// 
			this.MenuTitulo.AutoSize = false;
			this.MenuTitulo.BackColor = System.Drawing.Color.SteelBlue;
			this.MenuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
			this.MenuTitulo.Name = "MenuTitulo";
			this.MenuTitulo.Padding = new System.Windows.Forms.Padding(9, 5, 0, 5);
			this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.MenuTitulo.Size = new System.Drawing.Size(2223, 108);
			this.MenuTitulo.TabIndex = 1;
			this.MenuTitulo.Text = "Sistema de Ventas";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.SteelBlue;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(45, 17);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(560, 74);
			this.label1.TabIndex = 2;
			this.label1.Text = "Conoce tu ukelele :3";
			// 
			// Menu
			// 
			this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAcordes,
            this.MenuItemEscalas,
            this.MenuItemAfinacion,
            this.salirbtn});
			this.Menu.Location = new System.Drawing.Point(0, 108);
			this.Menu.Name = "Menu";
			this.Menu.Padding = new System.Windows.Forms.Padding(9, 5, 0, 5);
			this.Menu.Size = new System.Drawing.Size(2223, 96);
			this.Menu.Stretch = false;
			this.Menu.TabIndex = 0;
			this.Menu.Text = "menuStrip1";
			// 
			// MenuItemAcordes
			// 
			this.MenuItemAcordes.AutoSize = false;
			this.MenuItemAcordes.BackColor = System.Drawing.Color.White;
			this.MenuItemAcordes.IconChar = FontAwesome.Sharp.IconChar.Cogs;
			this.MenuItemAcordes.IconColor = System.Drawing.Color.Black;
			this.MenuItemAcordes.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.MenuItemAcordes.IconSize = 50;
			this.MenuItemAcordes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.MenuItemAcordes.Name = "MenuItemAcordes";
			this.MenuItemAcordes.Size = new System.Drawing.Size(250, 80);
			this.MenuItemAcordes.Text = "Generador de acordes";
			this.MenuItemAcordes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.MenuItemAcordes.Click += new System.EventHandler(this.MenuAcordes_Click);
			// 
			// MenuItemEscalas
			// 
			this.MenuItemEscalas.AutoSize = false;
			this.MenuItemEscalas.BackColor = System.Drawing.Color.White;
			this.MenuItemEscalas.IconChar = FontAwesome.Sharp.IconChar.ItunesNote;
			this.MenuItemEscalas.IconColor = System.Drawing.Color.Black;
			this.MenuItemEscalas.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.MenuItemEscalas.IconSize = 50;
			this.MenuItemEscalas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.MenuItemEscalas.Name = "MenuItemEscalas";
			this.MenuItemEscalas.Size = new System.Drawing.Size(180, 86);
			this.MenuItemEscalas.Text = "Escalas";
			this.MenuItemEscalas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.MenuItemEscalas.Click += new System.EventHandler(this.MenuEscalas_Click);
			// 
			// MenuItemAfinacion
			// 
			this.MenuItemAfinacion.AutoSize = false;
			this.MenuItemAfinacion.BackColor = System.Drawing.Color.White;
			this.MenuItemAfinacion.IconChar = FontAwesome.Sharp.IconChar.Guitar;
			this.MenuItemAfinacion.IconColor = System.Drawing.Color.Black;
			this.MenuItemAfinacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.MenuItemAfinacion.IconSize = 50;
			this.MenuItemAfinacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.MenuItemAfinacion.Name = "MenuItemAfinacion";
			this.MenuItemAfinacion.Size = new System.Drawing.Size(180, 86);
			this.MenuItemAfinacion.Text = "Mi afinacion";
			this.MenuItemAfinacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.MenuItemAfinacion.Click += new System.EventHandler(this.MenuItemAfinacion_Click);
			// 
			// salirbtn
			// 
			this.salirbtn.AutoSize = false;
			this.salirbtn.BackColor = System.Drawing.Color.White;
			this.salirbtn.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
			this.salirbtn.IconColor = System.Drawing.Color.Black;
			this.salirbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.salirbtn.IconSize = 50;
			this.salirbtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.salirbtn.Name = "salirbtn";
			this.salirbtn.Size = new System.Drawing.Size(180, 86);
			this.salirbtn.Text = "Salir";
			this.salirbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.salirbtn.Click += new System.EventHandler(this.salirbtn_Click);
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.BackColor = System.Drawing.Color.SteelBlue;
			this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblUsuario.ForeColor = System.Drawing.Color.White;
			this.lblUsuario.Location = new System.Drawing.Point(1852, 22);
			this.lblUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(0, 29);
			this.lblUsuario.TabIndex = 4;
			// 
			// contenedor
			// 
			this.contenedor.BackColor = System.Drawing.Color.White;
			this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contenedor.Location = new System.Drawing.Point(0, 204);
			this.contenedor.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.contenedor.Name = "contenedor";
			this.contenedor.Size = new System.Drawing.Size(2223, 1111);
			this.contenedor.TabIndex = 5;
			// 
			// Inicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2253, 1390);
			this.Controls.Add(this.contenedor);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Menu);
			this.Controls.Add(this.MenuTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.Menu;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(2253, 1390);
			this.MinimumSize = new System.Drawing.Size(2253, 1390);
			this.Name = "Inicio";
			this.Text = "Conoce tu ukelele";
			this.Load += new System.EventHandler(this.Inicio_Load);
			this.Menu.ResumeLayout(false);
			this.Menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip MenuTitulo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip Menu;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Panel contenedor;
		private FontAwesome.Sharp.IconMenuItem MenuItemAcordes;
		private FontAwesome.Sharp.IconMenuItem MenuItemEscalas;
		private FontAwesome.Sharp.IconMenuItem salirbtn;
		private FontAwesome.Sharp.IconMenuItem MenuItemAfinacion;
	}
}

