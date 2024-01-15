﻿namespace VtNetCore.VirtualTerminal.Layout;

public class LayoutSpan
{
    public string Text { get; set; }
    public string ForgroundColor { get; set; }
    public string BackgroundColor { get; set; }
    public bool Hidden { get; set; }
    public bool Italic { get; set; }
    public bool Bold { get; set; }
    public bool Underline { get; set; }
    public bool Blink { get; set; }
}
