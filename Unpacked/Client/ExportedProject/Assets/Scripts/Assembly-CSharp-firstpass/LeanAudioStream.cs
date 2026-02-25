//Type is in global namespace

[Token(Token = "0x2000004")]
public class LeanAudioStream
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000005")]
	public int position; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000006")]
	public AudioClip audioClip; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000007")]
	public Single[] audioArr; //Field offset: 0x20

	[Address(RVA = "0x2C33D0", Offset = "0x2C25D0", Length = "0x31")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	public LeanAudioStream(Single[] audioArr) { }

	[Address(RVA = "0x2C3360", Offset = "0x2C2560", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600000E")]
	public void OnAudioRead(Single[] data) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000F")]
	public void OnAudioSetPosition(int newPosition) { }

}

