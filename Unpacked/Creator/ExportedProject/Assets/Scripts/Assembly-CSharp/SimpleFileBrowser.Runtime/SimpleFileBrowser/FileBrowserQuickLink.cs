namespace SimpleFileBrowser;

[Token(Token = "0x200001B")]
public class FileBrowserQuickLink : FileBrowserItem
{
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40000CE")]
	private string m_targetPath; //Field offset: 0x88

	[Token(Token = "0x17000026")]
	public string TargetPath
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FC")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1541EE0", Offset = "0x15410E0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FE")]
	public FileBrowserQuickLink() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FC")]
	public string get_TargetPath() { }

	[Address(RVA = "0x15427C0", Offset = "0x15419C0", Length = "0x79")]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_PickFolderQuickLinkText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000FD")]
	public void SetQuickLink(Sprite icon, string name, string targetPath) { }

}

