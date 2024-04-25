﻿namespace Pokedex
{
    partial class Screen1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen1));
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.comboPokemons = new System.Windows.Forms.ComboBox();
            this.comboTypes = new System.Windows.Forms.ComboBox();
            this.comboBackup = new System.Windows.Forms.ComboBox();
            this.comboGeneration = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPokemonInfo = new System.Windows.Forms.Panel();
            this.panelDescBg = new System.Windows.Forms.Panel();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panelType2 = new System.Windows.Forms.Panel();
            this.lblType2 = new System.Windows.Forms.Label();
            this.panelType1 = new System.Windows.Forms.Panel();
            this.lblType1 = new System.Windows.Forms.Label();
            this.panelHeight = new System.Windows.Forms.Panel();
            this.lblPokeHeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.panelWeight = new System.Windows.Forms.Panel();
            this.lblPokeWeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.panelIdName = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picboxSprite = new System.Windows.Forms.PictureBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelPokemonInfo.SuspendLayout();
            this.panelDescBg.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.panelType2.SuspendLayout();
            this.panelType1.SuspendLayout();
            this.panelHeight.SuspendLayout();
            this.panelWeight.SuspendLayout();
            this.panelIdName.SuspendLayout();
            this.panelCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Black;
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLeft.FlatAppearance.BorderSize = 2;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLeft.Location = new System.Drawing.Point(309, 404);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(45, 33);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Black;
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRight.FlatAppearance.BorderSize = 2;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRight.Location = new System.Drawing.Point(387, 404);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(45, 33);
            this.btnRight.TabIndex = 7;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDown.FlatAppearance.BorderSize = 2;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDown.Location = new System.Drawing.Point(354, 437);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(33, 45);
            this.btnDown.TabIndex = 9;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUp.FlatAppearance.BorderSize = 2;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUp.Location = new System.Drawing.Point(354, 359);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(33, 45);
            this.btnUp.TabIndex = 8;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // comboPokemons
            // 
            this.comboPokemons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboPokemons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPokemons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPokemons.FormattingEnabled = true;
            this.comboPokemons.Location = new System.Drawing.Point(59, 47);
            this.comboPokemons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboPokemons.Name = "comboPokemons";
            this.comboPokemons.Size = new System.Drawing.Size(121, 28);
            this.comboPokemons.TabIndex = 2;
            this.comboPokemons.SelectedIndexChanged += new System.EventHandler(this.comboPokemons_SelectedIndexChanged);
            // 
            // comboTypes
            // 
            this.comboTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTypes.FormattingEnabled = true;
            this.comboTypes.Location = new System.Drawing.Point(305, 47);
            this.comboTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTypes.Name = "comboTypes";
            this.comboTypes.Size = new System.Drawing.Size(121, 28);
            this.comboTypes.TabIndex = 3;
            this.comboTypes.SelectedIndexChanged += new System.EventHandler(this.comboTypes_SelectedIndexChanged);
            // 
            // comboBackup
            // 
            this.comboBackup.FormattingEnabled = true;
            this.comboBackup.Location = new System.Drawing.Point(362, 530);
            this.comboBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBackup.Name = "comboBackup";
            this.comboBackup.Size = new System.Drawing.Size(121, 24);
            this.comboBackup.TabIndex = 11;
            this.comboBackup.Visible = false;
            // 
            // comboGeneration
            // 
            this.comboGeneration.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboGeneration.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGeneration.FormattingEnabled = true;
            this.comboGeneration.Location = new System.Drawing.Point(59, 19);
            this.comboGeneration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboGeneration.Name = "comboGeneration";
            this.comboGeneration.Size = new System.Drawing.Size(121, 28);
            this.comboGeneration.TabIndex = 1;
            this.comboGeneration.SelectedIndexChanged += new System.EventHandler(this.comboGeneration_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(354, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 33);
            this.panel1.TabIndex = 12;
            // 
            // panelPokemonInfo
            // 
            this.panelPokemonInfo.BackColor = System.Drawing.Color.White;
            this.panelPokemonInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPokemonInfo.BackgroundImage")));
            this.panelPokemonInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPokemonInfo.Controls.Add(this.panelDescBg);
            this.panelPokemonInfo.Controls.Add(this.panelType2);
            this.panelPokemonInfo.Controls.Add(this.panelType1);
            this.panelPokemonInfo.Controls.Add(this.panelHeight);
            this.panelPokemonInfo.Controls.Add(this.panelIdName);
            this.panelPokemonInfo.Controls.Add(this.picboxSprite);
            this.panelPokemonInfo.Location = new System.Drawing.Point(59, 91);
            this.panelPokemonInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPokemonInfo.Name = "panelPokemonInfo";
            this.panelPokemonInfo.Size = new System.Drawing.Size(367, 241);
            this.panelPokemonInfo.TabIndex = 8;
            // 
            // panelDescBg
            // 
            this.panelDescBg.BackColor = System.Drawing.Color.Red;
            this.panelDescBg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDescBg.Controls.Add(this.panelDescription);
            this.panelDescBg.Location = new System.Drawing.Point(15, 155);
            this.panelDescBg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDescBg.Name = "panelDescBg";
            this.panelDescBg.Size = new System.Drawing.Size(332, 69);
            this.panelDescBg.TabIndex = 14;
            // 
            // panelDescription
            // 
            this.panelDescription.BackColor = System.Drawing.Color.White;
            this.panelDescription.Controls.Add(this.lblDescription);
            this.panelDescription.Location = new System.Drawing.Point(5, -1);
            this.panelDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(320, 69);
            this.panelDescription.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(0, 0);
            this.lblDescription.MaximumSize = new System.Drawing.Size(331, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 20);
            this.lblDescription.TabIndex = 0;
            // 
            // panelType2
            // 
            this.panelType2.BackColor = System.Drawing.Color.White;
            this.panelType2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelType2.Controls.Add(this.lblType2);
            this.panelType2.Location = new System.Drawing.Point(268, 71);
            this.panelType2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelType2.Name = "panelType2";
            this.panelType2.Size = new System.Drawing.Size(75, 20);
            this.panelType2.TabIndex = 12;
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType2.ForeColor = System.Drawing.Color.White;
            this.lblType2.Location = new System.Drawing.Point(3, 1);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(0, 20);
            this.lblType2.TabIndex = 0;
            // 
            // panelType1
            // 
            this.panelType1.BackColor = System.Drawing.Color.White;
            this.panelType1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelType1.Controls.Add(this.lblType1);
            this.panelType1.Location = new System.Drawing.Point(187, 71);
            this.panelType1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelType1.Name = "panelType1";
            this.panelType1.Size = new System.Drawing.Size(75, 20);
            this.panelType1.TabIndex = 11;
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType1.ForeColor = System.Drawing.Color.White;
            this.lblType1.Location = new System.Drawing.Point(3, 1);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(0, 20);
            this.lblType1.TabIndex = 0;
            // 
            // panelHeight
            // 
            this.panelHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeight.Controls.Add(this.lblPokeHeight);
            this.panelHeight.Controls.Add(this.lblHeight);
            this.panelHeight.Controls.Add(this.panelWeight);
            this.panelHeight.Location = new System.Drawing.Point(228, 98);
            this.panelHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeight.Name = "panelHeight";
            this.panelHeight.Size = new System.Drawing.Size(119, 52);
            this.panelHeight.TabIndex = 10;
            // 
            // lblPokeHeight
            // 
            this.lblPokeHeight.AutoSize = true;
            this.lblPokeHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokeHeight.Location = new System.Drawing.Point(44, 5);
            this.lblPokeHeight.Name = "lblPokeHeight";
            this.lblPokeHeight.Size = new System.Drawing.Size(0, 20);
            this.lblPokeHeight.TabIndex = 13;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(8, 5);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(34, 20);
            this.lblHeight.TabIndex = 12;
            this.lblHeight.Text = "HT";
            // 
            // panelWeight
            // 
            this.panelWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWeight.Controls.Add(this.lblPokeWeight);
            this.panelWeight.Controls.Add(this.lblWeight);
            this.panelWeight.Location = new System.Drawing.Point(-1, 25);
            this.panelWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelWeight.Name = "panelWeight";
            this.panelWeight.Size = new System.Drawing.Size(127, 27);
            this.panelWeight.TabIndex = 11;
            // 
            // lblPokeWeight
            // 
            this.lblPokeWeight.AutoSize = true;
            this.lblPokeWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokeWeight.Location = new System.Drawing.Point(44, 5);
            this.lblPokeWeight.Name = "lblPokeWeight";
            this.lblPokeWeight.Size = new System.Drawing.Size(0, 20);
            this.lblPokeWeight.TabIndex = 14;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(6, 5);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(37, 20);
            this.lblWeight.TabIndex = 13;
            this.lblWeight.Text = "WT";
            // 
            // panelIdName
            // 
            this.panelIdName.BackColor = System.Drawing.Color.Red;
            this.panelIdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIdName.Controls.Add(this.panel2);
            this.panelIdName.Controls.Add(this.lblId);
            this.panelIdName.Controls.Add(this.panelCategory);
            this.panelIdName.Controls.Add(this.lblName);
            this.panelIdName.Location = new System.Drawing.Point(187, 17);
            this.panelIdName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelIdName.Name = "panelIdName";
            this.panelIdName.Size = new System.Drawing.Size(161, 48);
            this.panelIdName.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 15;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(20, 4);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 8;
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.White;
            this.panelCategory.Controls.Add(this.lblCategory);
            this.panelCategory.Location = new System.Drawing.Point(0, 23);
            this.panelCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(161, 25);
            this.panelCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(5, 6);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(0, 16);
            this.lblCategory.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(47, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 0;
            // 
            // picboxSprite
            // 
            this.picboxSprite.BackColor = System.Drawing.Color.Transparent;
            this.picboxSprite.Location = new System.Drawing.Point(29, 17);
            this.picboxSprite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxSprite.Name = "picboxSprite";
            this.picboxSprite.Size = new System.Drawing.Size(141, 129);
            this.picboxSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxSprite.TabIndex = 7;
            this.picboxSprite.TabStop = false;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.RaiseListChangedEvents = false;
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.RaiseListChangedEvents = false;
            // 
            // Screen1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(483, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboGeneration);
            this.Controls.Add(this.comboBackup);
            this.Controls.Add(this.comboTypes);
            this.Controls.Add(this.comboPokemons);
            this.Controls.Add(this.panelPokemonInfo);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Screen1";
            this.Text = "Pokedex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPokemonInfo.ResumeLayout(false);
            this.panelDescBg.ResumeLayout(false);
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.panelType2.ResumeLayout(false);
            this.panelType2.PerformLayout();
            this.panelType1.ResumeLayout(false);
            this.panelType1.PerformLayout();
            this.panelHeight.ResumeLayout(false);
            this.panelHeight.PerformLayout();
            this.panelWeight.ResumeLayout(false);
            this.panelWeight.PerformLayout();
            this.panelIdName.ResumeLayout(false);
            this.panelIdName.PerformLayout();
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.PictureBox picboxSprite;
        private System.Windows.Forms.Panel panelPokemonInfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox comboPokemons;
        private System.Windows.Forms.Panel panelIdName;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Panel panelHeight;
        private System.Windows.Forms.Label lblPokeHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Panel panelWeight;
        private System.Windows.Forms.Label lblPokeWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panelType2;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.Panel panelType1;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.ComboBox comboTypes;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.Panel panelDescBg;
        private System.Windows.Forms.ComboBox comboBackup;
        private System.Windows.Forms.ComboBox comboGeneration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

