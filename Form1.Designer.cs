namespace CS162_PopulationDatabaseFinal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cityDataGridView = new System.Windows.Forms.DataGridView();
            this.sortPop_Button = new System.Windows.Forms.Button();
            this.sortPopDESC_Button = new System.Windows.Forms.Button();
            this.sortCity_Button = new System.Windows.Forms.Button();
            this.getTotal_Button = new System.Windows.Forms.Button();
            this.getAverage_Button = new System.Windows.Forms.Button();
            this.getHighest_Button = new System.Windows.Forms.Button();
            this.getLowest_Button = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.populationDBDataSet = new CS162_PopulationDatabaseFinal.PopulationDBDataSet();
            this.cityTableAdapter = new CS162_PopulationDatabaseFinal.PopulationDBDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new CS162_PopulationDatabaseFinal.PopulationDBDataSetTableAdapters.TableAdapterManager();
            this.reset_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).BeginInit();
            this.cityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBindingNavigator
            // 
            this.cityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cityBindingNavigator.BindingSource = this.cityBindingSource;
            this.cityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cityBindingNavigatorSaveItem});
            this.cityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cityBindingNavigator.Name = "cityBindingNavigator";
            this.cityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cityBindingNavigator.Size = new System.Drawing.Size(475, 25);
            this.cityBindingNavigator.TabIndex = 0;
            this.cityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cityBindingNavigatorSaveItem
            // 
            this.cityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityBindingNavigatorSaveItem.Image")));
            this.cityBindingNavigatorSaveItem.Name = "cityBindingNavigatorSaveItem";
            this.cityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cityBindingNavigatorSaveItem.Text = "Save Data";
            this.cityBindingNavigatorSaveItem.Click += new System.EventHandler(this.cityBindingNavigatorSaveItem_Click);
            // 
            // cityDataGridView
            // 
            this.cityDataGridView.AutoGenerateColumns = false;
            this.cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cityDataGridView.DataSource = this.cityBindingSource;
            this.cityDataGridView.Location = new System.Drawing.Point(12, 28);
            this.cityDataGridView.Name = "cityDataGridView";
            this.cityDataGridView.Size = new System.Drawing.Size(244, 410);
            this.cityDataGridView.TabIndex = 1;
            // 
            // sortPop_Button
            // 
            this.sortPop_Button.Location = new System.Drawing.Point(262, 28);
            this.sortPop_Button.Name = "sortPop_Button";
            this.sortPop_Button.Size = new System.Drawing.Size(203, 23);
            this.sortPop_Button.TabIndex = 2;
            this.sortPop_Button.Text = "Sort Pop";
            this.sortPop_Button.UseVisualStyleBackColor = true;
            this.sortPop_Button.Click += new System.EventHandler(this.sortPop_Button_Click);
            // 
            // sortPopDESC_Button
            // 
            this.sortPopDESC_Button.Location = new System.Drawing.Point(262, 76);
            this.sortPopDESC_Button.Name = "sortPopDESC_Button";
            this.sortPopDESC_Button.Size = new System.Drawing.Size(203, 23);
            this.sortPopDESC_Button.TabIndex = 3;
            this.sortPopDESC_Button.Text = "Sort Pop DESC";
            this.sortPopDESC_Button.UseVisualStyleBackColor = true;
            this.sortPopDESC_Button.Click += new System.EventHandler(this.sortPopDESC_Button_Click);
            // 
            // sortCity_Button
            // 
            this.sortCity_Button.Location = new System.Drawing.Point(262, 124);
            this.sortCity_Button.Name = "sortCity_Button";
            this.sortCity_Button.Size = new System.Drawing.Size(203, 23);
            this.sortCity_Button.TabIndex = 4;
            this.sortCity_Button.Text = "Sort By City";
            this.sortCity_Button.UseVisualStyleBackColor = true;
            this.sortCity_Button.Click += new System.EventHandler(this.sortCity_Button_Click);
            // 
            // getTotal_Button
            // 
            this.getTotal_Button.Location = new System.Drawing.Point(262, 172);
            this.getTotal_Button.Name = "getTotal_Button";
            this.getTotal_Button.Size = new System.Drawing.Size(203, 23);
            this.getTotal_Button.TabIndex = 5;
            this.getTotal_Button.Text = "Get Total Pop";
            this.getTotal_Button.UseVisualStyleBackColor = true;
            this.getTotal_Button.Click += new System.EventHandler(this.getTotal_Button_Click);
            // 
            // getAverage_Button
            // 
            this.getAverage_Button.Location = new System.Drawing.Point(262, 220);
            this.getAverage_Button.Name = "getAverage_Button";
            this.getAverage_Button.Size = new System.Drawing.Size(203, 23);
            this.getAverage_Button.TabIndex = 6;
            this.getAverage_Button.Text = "Get Average Pop";
            this.getAverage_Button.UseVisualStyleBackColor = true;
            this.getAverage_Button.Click += new System.EventHandler(this.getAverage_Button_Click);
            // 
            // getHighest_Button
            // 
            this.getHighest_Button.Location = new System.Drawing.Point(262, 268);
            this.getHighest_Button.Name = "getHighest_Button";
            this.getHighest_Button.Size = new System.Drawing.Size(203, 23);
            this.getHighest_Button.TabIndex = 7;
            this.getHighest_Button.Text = "Get Highest Pop";
            this.getHighest_Button.UseVisualStyleBackColor = true;
            this.getHighest_Button.Click += new System.EventHandler(this.getHighest_Button_Click);
            // 
            // getLowest_Button
            // 
            this.getLowest_Button.Location = new System.Drawing.Point(262, 316);
            this.getLowest_Button.Name = "getLowest_Button";
            this.getLowest_Button.Size = new System.Drawing.Size(203, 23);
            this.getLowest_Button.TabIndex = 8;
            this.getLowest_Button.Text = "Get Lowest Pop";
            this.getLowest_Button.UseVisualStyleBackColor = true;
            this.getLowest_Button.Click += new System.EventHandler(this.getLowest_Button_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn1.HeaderText = "City";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn2.HeaderText = "Population";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.populationDBDataSet;
            // 
            // populationDBDataSet
            // 
            this.populationDBDataSet.DataSetName = "PopulationDBDataSet";
            this.populationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.UpdateOrder = CS162_PopulationDatabaseFinal.PopulationDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reset_Button
            // 
            this.reset_Button.BackColor = System.Drawing.Color.Gold;
            this.reset_Button.Location = new System.Drawing.Point(262, 364);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(203, 23);
            this.reset_Button.TabIndex = 9;
            this.reset_Button.Text = "Reset";
            this.reset_Button.UseVisualStyleBackColor = false;
            this.reset_Button.Click += new System.EventHandler(this.reset_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.BackColor = System.Drawing.Color.Tomato;
            this.exit_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit_Button.Location = new System.Drawing.Point(262, 412);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(203, 23);
            this.exit_Button.TabIndex = 10;
            this.exit_Button.Text = "EXIT";
            this.exit_Button.UseVisualStyleBackColor = false;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.reset_Button);
            this.Controls.Add(this.getLowest_Button);
            this.Controls.Add(this.getHighest_Button);
            this.Controls.Add(this.getAverage_Button);
            this.Controls.Add(this.getTotal_Button);
            this.Controls.Add(this.sortCity_Button);
            this.Controls.Add(this.sortPopDESC_Button);
            this.Controls.Add(this.sortPop_Button);
            this.Controls.Add(this.cityDataGridView);
            this.Controls.Add(this.cityBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).EndInit();
            this.cityBindingNavigator.ResumeLayout(false);
            this.cityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PopulationDBDataSet populationDBDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private PopulationDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private PopulationDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cityBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button sortPop_Button;
        private System.Windows.Forms.Button sortPopDESC_Button;
        private System.Windows.Forms.Button sortCity_Button;
        private System.Windows.Forms.Button getTotal_Button;
        private System.Windows.Forms.Button getAverage_Button;
        private System.Windows.Forms.Button getHighest_Button;
        private System.Windows.Forms.Button getLowest_Button;
        private System.Windows.Forms.Button reset_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

