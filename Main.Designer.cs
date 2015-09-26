namespace Silver
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Клиенты");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Неисправности");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Оборудование");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Предприятие     ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиСоединияСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортНеисправностейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортОборудованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрагентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неисправностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииОборудованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBoxInform = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView.Enabled = false;
            this.treeView.Location = new System.Drawing.Point(6, 11);
            this.treeView.Name = "treeView";
            treeNode1.Name = "clientTree";
            treeNode1.NodeFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic);
            treeNode1.Text = "Клиенты";
            treeNode2.Name = "brakeTree";
            treeNode2.NodeFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic);
            treeNode2.Text = "Неисправности";
            treeNode3.Name = "rigTree";
            treeNode3.NodeFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic);
            treeNode3.Text = "Оборудование";
            treeNode4.Name = "MainTree";
            treeNode4.NodeFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode4.Text = "Предприятие     ";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView.Size = new System.Drawing.Size(229, 491);
            this.treeView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.отчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиСоединияСБДToolStripMenuItem,
            this.импортНеисправностейToolStripMenuItem,
            this.импортОборудованияToolStripMenuItem,
            this.выгрузкаДанныхToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // настройкиСоединияСБДToolStripMenuItem
            // 
            this.настройкиСоединияСБДToolStripMenuItem.Name = "настройкиСоединияСБДToolStripMenuItem";
            this.настройкиСоединияСБДToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.настройкиСоединияСБДToolStripMenuItem.Text = "Настройки соединия с БД";
            this.настройкиСоединияСБДToolStripMenuItem.Click += new System.EventHandler(this.настройкиСоединияСБДToolStripMenuItem_Click);
            // 
            // импортНеисправностейToolStripMenuItem
            // 
            this.импортНеисправностейToolStripMenuItem.Name = "импортНеисправностейToolStripMenuItem";
            this.импортНеисправностейToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.импортНеисправностейToolStripMenuItem.Text = "Импорт неисправностей";
            // 
            // импортОборудованияToolStripMenuItem
            // 
            this.импортОборудованияToolStripMenuItem.Name = "импортОборудованияToolStripMenuItem";
            this.импортОборудованияToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.импортОборудованияToolStripMenuItem.Text = "Импорт оборудования";
            // 
            // выгрузкаДанныхToolStripMenuItem
            // 
            this.выгрузкаДанныхToolStripMenuItem.Name = "выгрузкаДанныхToolStripMenuItem";
            this.выгрузкаДанныхToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.выгрузкаДанныхToolStripMenuItem.Text = "Выгрузка данных";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрагентыToolStripMenuItem,
            this.неисправностиToolStripMenuItem,
            this.категорииОборудованияToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // контрагентыToolStripMenuItem
            // 
            this.контрагентыToolStripMenuItem.Name = "контрагентыToolStripMenuItem";
            this.контрагентыToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.контрагентыToolStripMenuItem.Text = "Контрагенты";
            // 
            // неисправностиToolStripMenuItem
            // 
            this.неисправностиToolStripMenuItem.Name = "неисправностиToolStripMenuItem";
            this.неисправностиToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.неисправностиToolStripMenuItem.Text = "Неисправности оборудования";
            // 
            // категорииОборудованияToolStripMenuItem
            // 
            this.категорииОборудованияToolStripMenuItem.Name = "категорииОборудованияToolStripMenuItem";
            this.категорииОборудованияToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.категорииОборудованияToolStripMenuItem.Text = "Категории оборудования";
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.treeView);
            this.groupBox1.Location = new System.Drawing.Point(2, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 512);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(241, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(882, 491);
            this.dataGridView1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBoxInform});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1136, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBoxInform
            // 
            this.textBoxInform.Name = "textBoxInform";
            this.textBoxInform.Size = new System.Drawing.Size(0, 17);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 566);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Silver";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиСоединияСБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортНеисправностейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортОборудованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрагентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неисправностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииОборудованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel textBoxInform;
    }
}

