namespace UnityEngine.UIElements;

[Token(Token = "0x2000535")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal interface IVisualTreeUpdater : IDisposable
{

	[Token(Token = "0x170009BE")]
	public long FrameCount
	{
		[Token(Token = "0x60025B1")]
		 get { } //Length: 0
		[Token(Token = "0x60025B2")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170009BF")]
	public BaseVisualElementPanel panel
	{
		[Token(Token = "0x60025B3")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170009C0")]
	public ProfilerMarker profilerMarker
	{
		[Token(Token = "0x60025B4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60025B1")]
	public long get_FrameCount() { }

	[Token(Token = "0x60025B4")]
	public ProfilerMarker get_profilerMarker() { }

	[Token(Token = "0x60025B6")]
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Token(Token = "0x60025B2")]
	public void set_FrameCount(long value) { }

	[Token(Token = "0x60025B3")]
	public void set_panel(BaseVisualElementPanel value) { }

	[Token(Token = "0x60025B5")]
	public void Update() { }

}

