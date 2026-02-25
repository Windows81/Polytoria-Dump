namespace UnityEngine.Accessibility;

[Flags]
[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeData.h")]
[Token(Token = "0x2000006")]
public enum AccessibilityRole
{
	None = 0,
	Button = 1,
	Image = 2,
	StaticText = 4,
	SearchField = 8,
	KeyboardKey = 16,
	Header = 32,
	TabBar = 64,
	Slider = 128,
	Toggle = 256,
}

