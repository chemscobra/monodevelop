
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.MonoDroid.Gui {
    internal partial class MonoDroidApplicationSettingsWidget {
        private global::Gtk.Table table1;
        
        private global::Gtk.ComboBoxEntry appIconCombo;
        
        private global::Gtk.Entry appNameEntry;
        
        private global::Gtk.ScrolledWindow GtkScrolledWindow;
        
        private global::Gtk.TreeView permissionsTreeView;
        
        private global::Gtk.Label label1;
        
        private global::Gtk.Label label2;
        
        private global::Gtk.Label label3;
        
        private global::Gtk.Label label4;
        
        private global::Gtk.Label label5;
        
        private global::Gtk.Label label6;
        
        private global::Gtk.Label label7;
        
        private global::Gtk.ComboBox minAndroidVersionCombo;
        
        private global::Gtk.Entry packageNameEntry;
        
        private global::Gtk.Entry versionNameEntry;
        
        private global::Gtk.Entry versionNumberEntry;
        
        protected virtual void Build() {
            global::Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.MonoDroid.Gui.MonoDroidApplicationSettingsWidget
            global::Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.MonoDroid.Gui.MonoDroidApplicationSettingsWidget";
            // Container child MonoDevelop.MonoDroid.Gui.MonoDroidApplicationSettingsWidget.Gtk.Container+ContainerChild
            this.table1 = new global::Gtk.Table(((uint)(7)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.appIconCombo = global::Gtk.ComboBoxEntry.NewText();
            this.appIconCombo.Name = "appIconCombo";
            this.table1.Add(this.appIconCombo);
            global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.appIconCombo]));
            w1.TopAttach = ((uint)(2));
            w1.BottomAttach = ((uint)(3));
            w1.LeftAttach = ((uint)(1));
            w1.RightAttach = ((uint)(2));
            w1.XOptions = ((global::Gtk.AttachOptions)(4));
            w1.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.appNameEntry = new global::Gtk.Entry();
            this.appNameEntry.CanFocus = true;
            this.appNameEntry.Name = "appNameEntry";
            this.appNameEntry.IsEditable = true;
            this.appNameEntry.InvisibleChar = '●';
            this.table1.Add(this.appNameEntry);
            global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.appNameEntry]));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.XOptions = ((global::Gtk.AttachOptions)(4));
            w2.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.permissionsTreeView = new global::Gtk.TreeView();
            this.permissionsTreeView.CanFocus = true;
            this.permissionsTreeView.Name = "permissionsTreeView";
            this.GtkScrolledWindow.Add(this.permissionsTreeView);
            this.table1.Add(this.GtkScrolledWindow);
            global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.GtkScrolledWindow]));
            w4.TopAttach = ((uint)(6));
            w4.BottomAttach = ((uint)(7));
            w4.LeftAttach = ((uint)(1));
            w4.RightAttach = ((uint)(2));
            // Container child table1.Gtk.Table+TableChild
            this.label1 = new global::Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("_Application name:");
            this.label1.UseUnderline = true;
            this.table1.Add(this.label1);
            global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
            w5.XOptions = ((global::Gtk.AttachOptions)(4));
            w5.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label2 = new global::Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xalign = 0F;
            this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("_Package name:");
            this.label2.UseUnderline = true;
            this.table1.Add(this.label2);
            global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
            w6.TopAttach = ((uint)(1));
            w6.BottomAttach = ((uint)(2));
            w6.XOptions = ((global::Gtk.AttachOptions)(4));
            w6.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label3 = new global::Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 0F;
            this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("_Version number:");
            this.label3.UseUnderline = true;
            this.table1.Add(this.label3);
            global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
            w7.TopAttach = ((uint)(3));
            w7.BottomAttach = ((uint)(4));
            w7.XOptions = ((global::Gtk.AttachOptions)(4));
            w7.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label4 = new global::Gtk.Label();
            this.label4.Name = "label4";
            this.label4.Xalign = 0F;
            this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Version _name:");
            this.label4.UseUnderline = true;
            this.table1.Add(this.label4);
            global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
            w8.TopAttach = ((uint)(4));
            w8.BottomAttach = ((uint)(5));
            w8.XOptions = ((global::Gtk.AttachOptions)(4));
            w8.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label5 = new global::Gtk.Label();
            this.label5.Name = "label5";
            this.label5.Xalign = 0F;
            this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("_Minimum Android version:");
            this.label5.UseUnderline = true;
            this.table1.Add(this.label5);
            global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
            w9.TopAttach = ((uint)(5));
            w9.BottomAttach = ((uint)(6));
            w9.XOptions = ((global::Gtk.AttachOptions)(4));
            w9.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label6 = new global::Gtk.Label();
            this.label6.Name = "label6";
            this.label6.Xalign = 0F;
            this.label6.Yalign = 0F;
            this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("_Required permissions:");
            this.label6.UseUnderline = true;
            this.table1.Add(this.label6);
            global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.label6]));
            w10.TopAttach = ((uint)(6));
            w10.BottomAttach = ((uint)(7));
            w10.XOptions = ((global::Gtk.AttachOptions)(4));
            w10.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label7 = new global::Gtk.Label();
            this.label7.Name = "label7";
            this.label7.Xalign = 0F;
            this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Application _Icon:");
            this.label7.UseUnderline = true;
            this.table1.Add(this.label7);
            global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.label7]));
            w11.TopAttach = ((uint)(2));
            w11.BottomAttach = ((uint)(3));
            w11.XOptions = ((global::Gtk.AttachOptions)(4));
            w11.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.minAndroidVersionCombo = global::Gtk.ComboBox.NewText();
            this.minAndroidVersionCombo.Name = "minAndroidVersionCombo";
            this.table1.Add(this.minAndroidVersionCombo);
            global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.minAndroidVersionCombo]));
            w12.TopAttach = ((uint)(5));
            w12.BottomAttach = ((uint)(6));
            w12.LeftAttach = ((uint)(1));
            w12.RightAttach = ((uint)(2));
            w12.XOptions = ((global::Gtk.AttachOptions)(4));
            w12.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.packageNameEntry = new global::Gtk.Entry();
            this.packageNameEntry.CanFocus = true;
            this.packageNameEntry.Name = "packageNameEntry";
            this.packageNameEntry.IsEditable = true;
            this.packageNameEntry.InvisibleChar = '●';
            this.table1.Add(this.packageNameEntry);
            global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.packageNameEntry]));
            w13.TopAttach = ((uint)(1));
            w13.BottomAttach = ((uint)(2));
            w13.LeftAttach = ((uint)(1));
            w13.RightAttach = ((uint)(2));
            w13.XOptions = ((global::Gtk.AttachOptions)(4));
            w13.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.versionNameEntry = new global::Gtk.Entry();
            this.versionNameEntry.CanFocus = true;
            this.versionNameEntry.Name = "versionNameEntry";
            this.versionNameEntry.IsEditable = true;
            this.versionNameEntry.InvisibleChar = '●';
            this.table1.Add(this.versionNameEntry);
            global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.versionNameEntry]));
            w14.TopAttach = ((uint)(4));
            w14.BottomAttach = ((uint)(5));
            w14.LeftAttach = ((uint)(1));
            w14.RightAttach = ((uint)(2));
            w14.XOptions = ((global::Gtk.AttachOptions)(4));
            w14.YOptions = ((global::Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.versionNumberEntry = new global::Gtk.Entry();
            this.versionNumberEntry.CanFocus = true;
            this.versionNumberEntry.Name = "versionNumberEntry";
            this.versionNumberEntry.IsEditable = true;
            this.versionNumberEntry.InvisibleChar = '●';
            this.table1.Add(this.versionNumberEntry);
            global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.versionNumberEntry]));
            w15.TopAttach = ((uint)(3));
            w15.BottomAttach = ((uint)(4));
            w15.LeftAttach = ((uint)(1));
            w15.RightAttach = ((uint)(2));
            w15.XOptions = ((global::Gtk.AttachOptions)(4));
            w15.YOptions = ((global::Gtk.AttachOptions)(4));
            this.Add(this.table1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.label1.MnemonicWidget = this.appNameEntry;
            this.label2.MnemonicWidget = this.packageNameEntry;
            this.label3.MnemonicWidget = this.versionNumberEntry;
            this.label4.MnemonicWidget = this.versionNameEntry;
            this.label5.MnemonicWidget = this.minAndroidVersionCombo;
            this.label6.MnemonicWidget = this.permissionsTreeView;
            this.Hide();
        }
    }
}
