namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerBuffer.h")]
[Token(Token = "0x2000009")]
public sealed class DownloadHandlerBuffer : DownloadHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001B")]
	private NativeArray<Byte> m_NativeData; //Field offset: 0x18

	[Address(RVA = "0x1CF7D50", Offset = "0x1CF6F50", Length = "0x3E")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.HttpService+<DoRequest>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003F")]
	public DownloadHandlerBuffer() { }

	[Address(RVA = "0x1CF7B30", Offset = "0x1CF6D30", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003D")]
	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	[Address(RVA = "0x1CF7B70", Offset = "0x1CF6D70", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000041")]
	public virtual void Dispose() { }

	[Address(RVA = "0x1CF7BF0", Offset = "0x1CF6DF0", Length = "0x11B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000040")]
	protected virtual NativeArray<Byte> GetNativeData() { }

	[Address(RVA = "0x1CF7D10", Offset = "0x1CF6F10", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003E")]
	private void InternalCreateBuffer() { }

}

