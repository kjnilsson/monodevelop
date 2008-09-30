// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.SourceEditor.OptionPanels {
    
    
    public partial class MarkerPanel {
        
        private Gtk.VBox vbox1;
        
        private Gtk.Label GtkLabel9;
        
        private Gtk.Alignment alignment1;
        
        private Gtk.VBox vbox3;
        
        private Gtk.CheckButton showLineNumbersCheckbutton;
        
        private Gtk.CheckButton underlineErrorsCheckbutton;
        
        private Gtk.CheckButton highlightMatchingBracketCheckbutton;
        
        private Gtk.CheckButton highlightCurrentLineCheckbutton;
        
        private Gtk.HBox hbox1;
        
        private Gtk.CheckButton showRulerCheckbutton;
        
        private Gtk.SpinButton rulerColSpinbutton;
        
        private Gtk.Label GtkLabel10;
        
        private Gtk.Alignment GtkAlignment;
        
        private Gtk.VBox vbox2;
        
        private Gtk.CheckButton showInvLinesCheckbutton;
        
        private Gtk.CheckButton showSpacesCheckbutton;
        
        private Gtk.CheckButton showTabsCheckbutton;
        
        private Gtk.CheckButton showEolCheckbutton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.SourceEditor.OptionPanels.MarkerPanel
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.SourceEditor.OptionPanels.MarkerPanel";
            // Container child MonoDevelop.SourceEditor.OptionPanels.MarkerPanel.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.GtkLabel9 = new Gtk.Label();
            this.GtkLabel9.Name = "GtkLabel9";
            this.GtkLabel9.Xalign = 0F;
            this.GtkLabel9.LabelProp = Mono.Unix.Catalog.GetString("<b>General</b>");
            this.GtkLabel9.UseMarkup = true;
            this.vbox1.Add(this.GtkLabel9);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkLabel9]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.alignment1 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment1.Name = "alignment1";
            this.alignment1.LeftPadding = ((uint)(12));
            // Container child alignment1.Gtk.Container+ContainerChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.showLineNumbersCheckbutton = new Gtk.CheckButton();
            this.showLineNumbersCheckbutton.CanFocus = true;
            this.showLineNumbersCheckbutton.Name = "showLineNumbersCheckbutton";
            this.showLineNumbersCheckbutton.Label = Mono.Unix.Catalog.GetString("_Show line numbers");
            this.showLineNumbersCheckbutton.DrawIndicator = true;
            this.showLineNumbersCheckbutton.UseUnderline = true;
            this.vbox3.Add(this.showLineNumbersCheckbutton);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox3[this.showLineNumbersCheckbutton]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.underlineErrorsCheckbutton = new Gtk.CheckButton();
            this.underlineErrorsCheckbutton.CanFocus = true;
            this.underlineErrorsCheckbutton.Name = "underlineErrorsCheckbutton";
            this.underlineErrorsCheckbutton.Label = Mono.Unix.Catalog.GetString("_Underline errors");
            this.underlineErrorsCheckbutton.DrawIndicator = true;
            this.underlineErrorsCheckbutton.UseUnderline = true;
            this.vbox3.Add(this.underlineErrorsCheckbutton);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox3[this.underlineErrorsCheckbutton]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.highlightMatchingBracketCheckbutton = new Gtk.CheckButton();
            this.highlightMatchingBracketCheckbutton.CanFocus = true;
            this.highlightMatchingBracketCheckbutton.Name = "highlightMatchingBracketCheckbutton";
            this.highlightMatchingBracketCheckbutton.Label = Mono.Unix.Catalog.GetString("_Highlight matching bracket");
            this.highlightMatchingBracketCheckbutton.DrawIndicator = true;
            this.highlightMatchingBracketCheckbutton.UseUnderline = true;
            this.vbox3.Add(this.highlightMatchingBracketCheckbutton);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox3[this.highlightMatchingBracketCheckbutton]));
            w4.Position = 2;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.highlightCurrentLineCheckbutton = new Gtk.CheckButton();
            this.highlightCurrentLineCheckbutton.CanFocus = true;
            this.highlightCurrentLineCheckbutton.Name = "highlightCurrentLineCheckbutton";
            this.highlightCurrentLineCheckbutton.Label = Mono.Unix.Catalog.GetString("Highlight _current line");
            this.highlightCurrentLineCheckbutton.DrawIndicator = true;
            this.highlightCurrentLineCheckbutton.UseUnderline = true;
            this.vbox3.Add(this.highlightCurrentLineCheckbutton);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox3[this.highlightCurrentLineCheckbutton]));
            w5.Position = 3;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.showRulerCheckbutton = new Gtk.CheckButton();
            this.showRulerCheckbutton.CanFocus = true;
            this.showRulerCheckbutton.Name = "showRulerCheckbutton";
            this.showRulerCheckbutton.Label = Mono.Unix.Catalog.GetString("Show _column ruler, at column:");
            this.showRulerCheckbutton.DrawIndicator = true;
            this.showRulerCheckbutton.UseUnderline = true;
            this.hbox1.Add(this.showRulerCheckbutton);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox1[this.showRulerCheckbutton]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.rulerColSpinbutton = new Gtk.SpinButton(0, 1024, 1);
            this.rulerColSpinbutton.CanFocus = true;
            this.rulerColSpinbutton.Name = "rulerColSpinbutton";
            this.rulerColSpinbutton.Adjustment.PageIncrement = 10;
            this.rulerColSpinbutton.ClimbRate = 1;
            this.rulerColSpinbutton.Numeric = true;
            this.rulerColSpinbutton.Value = 80;
            this.hbox1.Add(this.rulerColSpinbutton);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox1[this.rulerColSpinbutton]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            this.vbox3.Add(this.hbox1);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
            w8.Position = 4;
            w8.Expand = false;
            w8.Fill = false;
            this.alignment1.Add(this.vbox3);
            this.vbox1.Add(this.alignment1);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox1[this.alignment1]));
            w10.Position = 1;
            w10.Expand = false;
            w10.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.GtkLabel10 = new Gtk.Label();
            this.GtkLabel10.Name = "GtkLabel10";
            this.GtkLabel10.Xalign = 0F;
            this.GtkLabel10.LabelProp = Mono.Unix.Catalog.GetString("<b>Whitespace Markers</b>");
            this.GtkLabel10.UseMarkup = true;
            this.vbox1.Add(this.GtkLabel10);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkLabel10]));
            w11.Position = 2;
            w11.Expand = false;
            w11.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.GtkAlignment = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment.Name = "GtkAlignment";
            this.GtkAlignment.LeftPadding = ((uint)(12));
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.showInvLinesCheckbutton = new Gtk.CheckButton();
            this.showInvLinesCheckbutton.CanFocus = true;
            this.showInvLinesCheckbutton.Name = "showInvLinesCheckbutton";
            this.showInvLinesCheckbutton.Label = Mono.Unix.Catalog.GetString("_Invalid lines");
            this.showInvLinesCheckbutton.DrawIndicator = true;
            this.showInvLinesCheckbutton.UseUnderline = true;
            this.vbox2.Add(this.showInvLinesCheckbutton);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox2[this.showInvLinesCheckbutton]));
            w12.Position = 0;
            w12.Expand = false;
            w12.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.showSpacesCheckbutton = new Gtk.CheckButton();
            this.showSpacesCheckbutton.CanFocus = true;
            this.showSpacesCheckbutton.Name = "showSpacesCheckbutton";
            this.showSpacesCheckbutton.Label = Mono.Unix.Catalog.GetString("S_paces");
            this.showSpacesCheckbutton.DrawIndicator = true;
            this.showSpacesCheckbutton.UseUnderline = true;
            this.vbox2.Add(this.showSpacesCheckbutton);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.vbox2[this.showSpacesCheckbutton]));
            w13.Position = 1;
            w13.Expand = false;
            w13.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.showTabsCheckbutton = new Gtk.CheckButton();
            this.showTabsCheckbutton.CanFocus = true;
            this.showTabsCheckbutton.Name = "showTabsCheckbutton";
            this.showTabsCheckbutton.Label = Mono.Unix.Catalog.GetString("_Tabs");
            this.showTabsCheckbutton.DrawIndicator = true;
            this.showTabsCheckbutton.UseUnderline = true;
            this.vbox2.Add(this.showTabsCheckbutton);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox2[this.showTabsCheckbutton]));
            w14.Position = 2;
            w14.Expand = false;
            w14.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.showEolCheckbutton = new Gtk.CheckButton();
            this.showEolCheckbutton.CanFocus = true;
            this.showEolCheckbutton.Name = "showEolCheckbutton";
            this.showEolCheckbutton.Label = Mono.Unix.Catalog.GetString("_End of line");
            this.showEolCheckbutton.DrawIndicator = true;
            this.showEolCheckbutton.UseUnderline = true;
            this.vbox2.Add(this.showEolCheckbutton);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox2[this.showEolCheckbutton]));
            w15.Position = 3;
            w15.Expand = false;
            w15.Fill = false;
            this.GtkAlignment.Add(this.vbox2);
            this.vbox1.Add(this.GtkAlignment);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkAlignment]));
            w17.Position = 3;
            w17.Expand = false;
            w17.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
