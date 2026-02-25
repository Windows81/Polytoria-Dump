namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandlerRaw.h")]
[Token(Token = "0x2000013")]
public sealed class UploadHandlerRaw : UploadHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400005C")]
	private NativeArray<Byte> m_Payload; //Field offset: 0x18

	[Address(RVA = "0x1CFBA50", Offset = "0x1CFAC50", Length = "0x163")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.HttpService+<DoRequest>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(WWWForm)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000098")]
	public UploadHandlerRaw(Byte[] data) { }

	[Address(RVA = "0x1CFBBC0", Offset = "0x1CFADC0", Length = "0xE4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000099")]
	public UploadHandlerRaw(NativeArray<Byte> data, bool transferOwnership) { }

	[Address(RVA = "0x1CFB960", Offset = "0x1CFAB60", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000097")]
	private static IntPtr Create(UploadHandlerRaw self, Byte* data, int dataLength) { }

	[Address(RVA = "0x1CFB9C0", Offset = "0x1CFABC0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009A")]
	public virtual void Dispose() { }

}

