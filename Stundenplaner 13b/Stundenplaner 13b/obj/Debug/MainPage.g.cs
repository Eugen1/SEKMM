﻿

#pragma checksum "C:\Users\Eugen Romanenkov\Downloads\SEKMM-Stundenplaner-master\SEKMM-Stundenplaner-master\Stundenplaner 13b\Stundenplaner 13b\..\..\..\..\..\Desktop\JahresProjekt\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7B47162CF28494EE0B3A99A1E7E69DF4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stundenplaner_13b
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 23 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.PausenLaenge_TextChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 25 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.WeiterePausenLaenge_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


