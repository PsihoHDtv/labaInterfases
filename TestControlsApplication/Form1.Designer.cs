﻿//using PluginInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace TestControlsApplication
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
            this.components = new System.ComponentModel.Container();
            this.filePathSelect1 = new LabControls.FilePathSelect();
            this.numberBox1 = new LabControls.NumberBox(this.components);
            this.rgbControl1 = new LabControls.rgbControl();
            this.SuspendLayout();
            // 
            // filePathSelect1
            // 
            this.filePathSelect1.FileName = "";
            this.filePathSelect1.Location = new System.Drawing.Point(59, 82);
            this.filePathSelect1.Name = "filePathSelect1";
            this.filePathSelect1.Size = new System.Drawing.Size(344, 28);
            this.filePathSelect1.TabIndex = 1;
            // 
            // numberBox1
            // 
            this.numberBox1.ForeColor = System.Drawing.Color.Red;
            this.numberBox1.Location = new System.Drawing.Point(72, 39);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(100, 20);
            this.numberBox1.TabIndex = 0;
            // 
            // rgbControl1
            // 
            this.rgbControl1.Location = new System.Drawing.Point(457, 130);
            this.rgbControl1.Name = "rgbControl1";
            this.rgbControl1.Size = new System.Drawing.Size(283, 150);
            this.rgbControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rgbControl1);
            this.Controls.Add(this.filePathSelect1);
            this.Controls.Add(this.numberBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
            //FindPlugins();
        }
        //Dictionary<string, IPlugin> plugins = new Dictionary<string, IPlugin>();
        //void FindPlugins()
        //{
        //    // папка с плагинами
        //    string folder = System.AppDomain.CurrentDomain.BaseDirectory;
        //    // dll-файлы в этой папке
        //    string[] files = Directory.GetFiles(folder, "*.dll");
        //    foreach (string file in files)
        //        try
        //        {
        //            Assembly assembly = Assembly.LoadFile(file);
        //            foreach (Type type in assembly.GetTypes())
        //            {
        //                Type iface = type.GetInterface("Interface.IPlugin");
        //                if (iface != null)
        //                {
        //                    PluginInterface.IPlugin plugin = (PluginInterface.IPlugin)Activator.CreateInstance(type);
        //                    plugins.Add(plugin.Name, plugin);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(" Ошибка загрузки плагина\n" + ex.Message);
        //        }
        //}
       
        #endregion

        private LabControls.NumberBox numberBox1;
        private LabControls.FilePathSelect filePathSelect1;
        private LabControls.rgbControl rgbControl1;
    }
}

