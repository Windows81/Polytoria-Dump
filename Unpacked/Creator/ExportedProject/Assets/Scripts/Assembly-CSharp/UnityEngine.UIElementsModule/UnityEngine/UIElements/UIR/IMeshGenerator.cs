namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000579")]
internal interface IMeshGenerator
{

	[Token(Token = "0x170009E7")]
	public VisualElement currentElement
	{
		[Token(Token = "0x6002715")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170009E8")]
	public TextJobSystem textJobSystem
	{
		[Token(Token = "0x6002716")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600271A")]
	public void DrawBorder(BorderParams borderParams) { }

	[Token(Token = "0x6002719")]
	public void DrawRectangle(RectangleParams rectParams) { }

	[Token(Token = "0x600271B")]
	public void DrawRectangleRepeat(RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	[Token(Token = "0x6002717")]
	public void DrawText(List<NativeSlice`1<Vertex>> vertices, List<NativeSlice`1<UInt16>> indices, List<Texture2D> atlases, List<GlyphRenderMode> renderModes, List<Single> sdfScales) { }

	[Token(Token = "0x6002718")]
	public void DrawText(List<NativeSlice`1<Vertex>> vertices, List<NativeSlice`1<UInt16>> indices, List<Material> materials, List<GlyphRenderMode> renderModes) { }

	[Token(Token = "0x6002716")]
	public TextJobSystem get_textJobSystem() { }

	[Token(Token = "0x600271C")]
	public void ScheduleJobs(MeshGenerationContext mgc) { }

	[Token(Token = "0x6002715")]
	public void set_currentElement(VisualElement value) { }

}

