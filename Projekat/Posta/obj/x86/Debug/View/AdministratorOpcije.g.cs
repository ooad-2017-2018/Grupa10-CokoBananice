﻿#pragma checksum "C:\Users\spahi\Desktop\SMTH GRUPA\Grupa10-CokoBananice\Projekat\Posta\View\AdministratorOpcije.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1FD55CB99B216760624216469236E9F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Posta.Forms
{
    partial class AdministratorOpcije : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\View\AdministratorOpcije.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.bPrikazRacuna = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\View\AdministratorOpcije.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bPrikazRacuna).Click += this.bPrikazRacuna_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 30 "..\..\..\View\AdministratorOpcije.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.textBox).TextChanged += this.textBox_TextChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.bObrisiPotrosaca = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\View\AdministratorOpcije.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bObrisiPotrosaca).Click += this.bObrisiPotrosaca_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.bPodaciPotrosaca = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 33 "..\..\..\View\AdministratorOpcije.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bPodaciPotrosaca).Click += this.bPodaciPotrosaca_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.bPretraga = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 34 "..\..\..\View\AdministratorOpcije.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bPretraga).Click += this.bPretraga_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

