﻿namespace WebApi.Host
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.WebApiHostServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.WebApiHostServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // WebApiHostServiceProcessInstaller
            // 
            this.WebApiHostServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.WebApiHostServiceProcessInstaller.Password = null;
            this.WebApiHostServiceProcessInstaller.Username = null;
            // 
            // WebApiHostServiceInstaller
            // 
            this.WebApiHostServiceInstaller.Description = "WebApiHost";
            this.WebApiHostServiceInstaller.DisplayName = "WebApiHost";
            this.WebApiHostServiceInstaller.ServiceName = "WebApiHostService";
            this.WebApiHostServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.WebApiHostServiceProcessInstaller,
            this.WebApiHostServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller WebApiHostServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller WebApiHostServiceInstaller;
    }
}