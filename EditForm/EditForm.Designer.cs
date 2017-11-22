namespace EditForm
{
    partial class EditMatrix
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.txtBox_Width = new System.Windows.Forms.TextBox();
            this.txtBox_Length = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_road = new System.Windows.Forms.Label();
            this.lbl_TowerPlace = new System.Windows.Forms.Label();
            this.lbl_ground = new System.Windows.Forms.Label();
            this.lbl_finish = new System.Windows.Forms.Label();
            this.lbl_startPosition = new System.Windows.Forms.Label();
            this.pBoxFinish = new System.Windows.Forms.PictureBox();
            this.pBoxTowerPlace = new System.Windows.Forms.PictureBox();
            this.pBoxEnemyRoad = new System.Windows.Forms.PictureBox();
            this.pBoxTower = new System.Windows.Forms.PictureBox();
            this.pBoxStart = new System.Windows.Forms.PictureBox();
            this.rBox_log = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTowerPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEnemyRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStart)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Location = new System.Drawing.Point(897, 632);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(819, 24);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(87, 13);
            this.lbl_Width.TabIndex = 1;
            this.lbl_Width.Text = "Width(max=100):";
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Location = new System.Drawing.Point(819, 50);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(95, 13);
            this.lbl_Length.TabIndex = 1;
            this.lbl_Length.Text = "Length(max=100): ";
            // 
            // txtBox_Width
            // 
            this.txtBox_Width.Location = new System.Drawing.Point(920, 17);
            this.txtBox_Width.Name = "txtBox_Width";
            this.txtBox_Width.Size = new System.Drawing.Size(52, 20);
            this.txtBox_Width.TabIndex = 0;
            this.txtBox_Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Width_KeyPress);
            // 
            // txtBox_Length
            // 
            this.txtBox_Length.Location = new System.Drawing.Point(920, 47);
            this.txtBox_Length.Name = "txtBox_Length";
            this.txtBox_Length.Size = new System.Drawing.Size(52, 20);
            this.txtBox_Length.TabIndex = 1;
            this.txtBox_Length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Length_KeyPress);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(872, 73);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(100, 23);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Create Matrix";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_road
            // 
            this.lbl_road.AutoSize = true;
            this.lbl_road.Location = new System.Drawing.Point(667, 32);
            this.lbl_road.Name = "lbl_road";
            this.lbl_road.Size = new System.Drawing.Size(33, 13);
            this.lbl_road.TabIndex = 6;
            this.lbl_road.Text = "Road";
            // 
            // lbl_TowerPlace
            // 
            this.lbl_TowerPlace.AutoSize = true;
            this.lbl_TowerPlace.Location = new System.Drawing.Point(723, 31);
            this.lbl_TowerPlace.Name = "lbl_TowerPlace";
            this.lbl_TowerPlace.Size = new System.Drawing.Size(37, 13);
            this.lbl_TowerPlace.TabIndex = 7;
            this.lbl_TowerPlace.Text = "Tower";
            // 
            // lbl_ground
            // 
            this.lbl_ground.AutoSize = true;
            this.lbl_ground.Location = new System.Drawing.Point(609, 31);
            this.lbl_ground.Name = "lbl_ground";
            this.lbl_ground.Size = new System.Drawing.Size(42, 13);
            this.lbl_ground.TabIndex = 8;
            this.lbl_ground.Text = "Ground";
            // 
            // lbl_finish
            // 
            this.lbl_finish.AutoSize = true;
            this.lbl_finish.Location = new System.Drawing.Point(551, 31);
            this.lbl_finish.Name = "lbl_finish";
            this.lbl_finish.Size = new System.Drawing.Size(34, 13);
            this.lbl_finish.TabIndex = 8;
            this.lbl_finish.Text = "Finish";
            // 
            // lbl_startPosition
            // 
            this.lbl_startPosition.AutoSize = true;
            this.lbl_startPosition.Location = new System.Drawing.Point(493, 31);
            this.lbl_startPosition.Name = "lbl_startPosition";
            this.lbl_startPosition.Size = new System.Drawing.Size(29, 13);
            this.lbl_startPosition.TabIndex = 8;
            this.lbl_startPosition.Text = "Start";
            // 
            // pBoxFinish
            // 
            this.pBoxFinish.Image = global::EditForm.Properties.Resources.Screenshot_6;
            this.pBoxFinish.Location = new System.Drawing.Point(554, 47);
            this.pBoxFinish.Name = "pBoxFinish";
            this.pBoxFinish.Size = new System.Drawing.Size(30, 30);
            this.pBoxFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxFinish.TabIndex = 5;
            this.pBoxFinish.TabStop = false;
            this.pBoxFinish.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBoxFinish_MouseClick);
            // 
            // pBoxTowerPlace
            // 
            this.pBoxTowerPlace.Image = global::EditForm.Properties.Resources.Screenshot_7;
            this.pBoxTowerPlace.Location = new System.Drawing.Point(728, 47);
            this.pBoxTowerPlace.Name = "pBoxTowerPlace";
            this.pBoxTowerPlace.Size = new System.Drawing.Size(30, 30);
            this.pBoxTowerPlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxTowerPlace.TabIndex = 5;
            this.pBoxTowerPlace.TabStop = false;
            this.pBoxTowerPlace.DragOver += new System.Windows.Forms.DragEventHandler(this.pBoxTowerPlace_DragOver);
            this.pBoxTowerPlace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBoxTowerPlace_MouseClick);
            // 
            // pBoxEnemyRoad
            // 
            this.pBoxEnemyRoad.Image = global::EditForm.Properties.Resources.images;
            this.pBoxEnemyRoad.Location = new System.Drawing.Point(670, 47);
            this.pBoxEnemyRoad.Name = "pBoxEnemyRoad";
            this.pBoxEnemyRoad.Size = new System.Drawing.Size(30, 30);
            this.pBoxEnemyRoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxEnemyRoad.TabIndex = 5;
            this.pBoxEnemyRoad.TabStop = false;
            this.pBoxEnemyRoad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBoxEnemyRoad_MouseClick);
            // 
            // pBoxTower
            // 
            this.pBoxTower.Image = global::EditForm.Properties.Resources.Screenshot_4;
            this.pBoxTower.Location = new System.Drawing.Point(612, 47);
            this.pBoxTower.Name = "pBoxTower";
            this.pBoxTower.Size = new System.Drawing.Size(30, 30);
            this.pBoxTower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxTower.TabIndex = 5;
            this.pBoxTower.TabStop = false;
            this.pBoxTower.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBoxTower_MouseClick);
            // 
            // pBoxStart
            // 
            this.pBoxStart.Image = global::EditForm.Properties.Resources.Screenshot_3;
            this.pBoxStart.Location = new System.Drawing.Point(496, 47);
            this.pBoxStart.Name = "pBoxStart";
            this.pBoxStart.Size = new System.Drawing.Size(30, 30);
            this.pBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxStart.TabIndex = 5;
            this.pBoxStart.TabStop = false;
            this.pBoxStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBoxStart_MouseClick);
            // 
            // rBox_log
            // 
            this.rBox_log.Location = new System.Drawing.Point(872, 114);
            this.rBox_log.Name = "rBox_log";
            this.rBox_log.ReadOnly = true;
            this.rBox_log.Size = new System.Drawing.Size(100, 512);
            this.rBox_log.TabIndex = 9;
            this.rBox_log.Text = "";
            // 
            // EditMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 667);
            this.Controls.Add(this.rBox_log);
            this.Controls.Add(this.lbl_startPosition);
            this.Controls.Add(this.lbl_finish);
            this.Controls.Add(this.lbl_ground);
            this.Controls.Add(this.lbl_TowerPlace);
            this.Controls.Add(this.lbl_road);
            this.Controls.Add(this.pBoxFinish);
            this.Controls.Add(this.pBoxTowerPlace);
            this.Controls.Add(this.pBoxEnemyRoad);
            this.Controls.Add(this.pBoxTower);
            this.Controls.Add(this.pBoxStart);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txtBox_Length);
            this.Controls.Add(this.txtBox_Width);
            this.Controls.Add(this.lbl_Length);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.btn_edit);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "EditMatrix";
            this.Text = "Edit Matrix";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditMatrix_FormClosed);
            this.Load += new System.EventHandler(this.EditMatrix_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EditMatrix_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditMatrix_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTowerPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEnemyRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.TextBox txtBox_Width;
        private System.Windows.Forms.TextBox txtBox_Length;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.PictureBox pBoxStart;
        private System.Windows.Forms.PictureBox pBoxFinish;
        private System.Windows.Forms.PictureBox pBoxTower;
        private System.Windows.Forms.PictureBox pBoxEnemyRoad;
        private System.Windows.Forms.PictureBox pBoxTowerPlace;
        private System.Windows.Forms.Label lbl_road;
        private System.Windows.Forms.Label lbl_TowerPlace;
        private System.Windows.Forms.Label lbl_ground;
        private System.Windows.Forms.Label lbl_finish;
        private System.Windows.Forms.Label lbl_startPosition;
        private System.Windows.Forms.RichTextBox rBox_log;
    }
}

