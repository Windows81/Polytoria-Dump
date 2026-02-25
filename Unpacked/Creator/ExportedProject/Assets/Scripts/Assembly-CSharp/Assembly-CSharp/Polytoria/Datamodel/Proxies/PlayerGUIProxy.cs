namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003B5")]
public class PlayerGUIProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FFF")]
	private readonly PlayerGUI playerGUI; //Field offset: 0x18

	[Token(Token = "0x17000C08")]
	public bool Interactable
	{
		[Address(RVA = "0x4A3FC0", Offset = "0x4A31C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600283E")]
		 get { } //Length: 30
		[Address(RVA = "0x4A7320", Offset = "0x4A6520", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerGUI), Member = "set_Interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600283F")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C07")]
	public float Opacity
	{
		[Address(RVA = "0x4A1100", Offset = "0x4A0300", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600283C")]
		 get { } //Length: 31
		[Address(RVA = "0x4A7340", Offset = "0x4A6540", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerGUI), Member = "set_Opacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600283D")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x600283B")]
	public PlayerGUIProxy(PlayerGUI target) { }

	[Address(RVA = "0x4A3FC0", Offset = "0x4A31C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600283E")]
	public bool get_Interactable() { }

	[Address(RVA = "0x4A1100", Offset = "0x4A0300", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600283C")]
	public float get_Opacity() { }

	[Address(RVA = "0x4A7320", Offset = "0x4A6520", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerGUI), Member = "set_Interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600283F")]
	public void set_Interactable(bool value) { }

	[Address(RVA = "0x4A7340", Offset = "0x4A6540", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerGUI), Member = "set_Opacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600283D")]
	public void set_Opacity(float value) { }

}

