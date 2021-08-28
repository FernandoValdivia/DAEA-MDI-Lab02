
namespace Semana2
{
    partial class PrincipalMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mntUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mntProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mntCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mntProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mntClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.proRegisVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.proRegisCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.rptVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.rptCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.rptInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.rptProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.rptUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.rptClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.sistSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntUsuarios,
            this.mntProductos,
            this.mntCategorias,
            this.mntProveedores,
            this.mntClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proRegisVenta,
            this.proRegisCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rptVentas,
            this.rptCompras,
            this.rptInventario,
            this.rptProveedores,
            this.rptUsuarios,
            this.rptClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mntUsuarios
            // 
            this.mntUsuarios.Name = "mntUsuarios";
            this.mntUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mntUsuarios.Text = "Usuarios";
            this.mntUsuarios.Click += new System.EventHandler(this.mntUsuarios_Click);
            // 
            // mntProductos
            // 
            this.mntProductos.Name = "mntProductos";
            this.mntProductos.Size = new System.Drawing.Size(180, 22);
            this.mntProductos.Text = "Productos";
            // 
            // mntCategorias
            // 
            this.mntCategorias.Name = "mntCategorias";
            this.mntCategorias.Size = new System.Drawing.Size(180, 22);
            this.mntCategorias.Text = "Categorías";
            // 
            // mntProveedores
            // 
            this.mntProveedores.Name = "mntProveedores";
            this.mntProveedores.Size = new System.Drawing.Size(180, 22);
            this.mntProveedores.Text = "Proveedores";
            // 
            // mntClientes
            // 
            this.mntClientes.Name = "mntClientes";
            this.mntClientes.Size = new System.Drawing.Size(180, 22);
            this.mntClientes.Text = "Clientes";
            // 
            // proRegisVenta
            // 
            this.proRegisVenta.Name = "proRegisVenta";
            this.proRegisVenta.Size = new System.Drawing.Size(180, 22);
            this.proRegisVenta.Text = "Registrar Venta";
            // 
            // proRegisCompra
            // 
            this.proRegisCompra.Name = "proRegisCompra";
            this.proRegisCompra.Size = new System.Drawing.Size(180, 22);
            this.proRegisCompra.Text = "Registrar Compra";
            // 
            // rptVentas
            // 
            this.rptVentas.Name = "rptVentas";
            this.rptVentas.Size = new System.Drawing.Size(200, 22);
            this.rptVentas.Text = "Reporte de Ventas";
            // 
            // rptCompras
            // 
            this.rptCompras.Name = "rptCompras";
            this.rptCompras.Size = new System.Drawing.Size(200, 22);
            this.rptCompras.Text = "Reporte de Compras";
            // 
            // rptInventario
            // 
            this.rptInventario.Name = "rptInventario";
            this.rptInventario.Size = new System.Drawing.Size(200, 22);
            this.rptInventario.Text = "Inventario de Productos";
            // 
            // rptProveedores
            // 
            this.rptProveedores.Name = "rptProveedores";
            this.rptProveedores.Size = new System.Drawing.Size(200, 22);
            this.rptProveedores.Text = "Reporte de Proveedores";
            // 
            // rptUsuarios
            // 
            this.rptUsuarios.Name = "rptUsuarios";
            this.rptUsuarios.Size = new System.Drawing.Size(200, 22);
            this.rptUsuarios.Text = "Reporte de Usuarios";
            // 
            // rptClientes
            // 
            this.rptClientes.Name = "rptClientes";
            this.rptClientes.Size = new System.Drawing.Size(200, 22);
            this.rptClientes.Text = "Reporte de Clientes";
            // 
            // sistSalir
            // 
            this.sistSalir.Name = "sistSalir";
            this.sistSalir.Size = new System.Drawing.Size(180, 22);
            this.sistSalir.Text = "Salir del sistema";
            this.sistSalir.Click += new System.EventHandler(this.sistSalir_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mntUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mntProductos;
        private System.Windows.Forms.ToolStripMenuItem mntCategorias;
        private System.Windows.Forms.ToolStripMenuItem mntProveedores;
        private System.Windows.Forms.ToolStripMenuItem mntClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proRegisVenta;
        private System.Windows.Forms.ToolStripMenuItem proRegisCompra;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rptVentas;
        private System.Windows.Forms.ToolStripMenuItem rptCompras;
        private System.Windows.Forms.ToolStripMenuItem rptInventario;
        private System.Windows.Forms.ToolStripMenuItem rptProveedores;
        private System.Windows.Forms.ToolStripMenuItem rptUsuarios;
        private System.Windows.Forms.ToolStripMenuItem rptClientes;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistSalir;
    }
}