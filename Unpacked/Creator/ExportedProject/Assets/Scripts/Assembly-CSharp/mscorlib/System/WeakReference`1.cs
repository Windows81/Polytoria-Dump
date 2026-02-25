namespace System;

[Token(Token = "0x20001DB")]
public sealed class WeakReference : ISerializable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000949")]
	private GCHandle handle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400094A")]
	private bool trackResurrection; //Field offset: 0x0

	[Address(RVA = "0x92FCB0", Offset = "0x92EEB0", Length = "0x37")]
	[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Security.SslStream", "Mono.Net.Security.MobileTlsProvider", "Mono.Security.Interface.MonoTlsSettings", typeof(bool), "Mono.Net.Security.MonoTlsStream"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Text.RegularExpressions.RegexOptions", typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "InitializeReferences", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Pool.PoolManager", Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Pool.IPool"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "RegisterCallbackInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_FontAsset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "RegisterCallbackInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600106E")]
	public WeakReference`1(T target) { }

	[Address(RVA = "0x92FCF0", Offset = "0x92EEF0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600106F")]
	public WeakReference`1(T target, bool trackResurrection) { }

	[Address(RVA = "0x92FB90", Offset = "0x92ED90", Length = "0x118")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001070")]
	private WeakReference`1(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x92F8A0", Offset = "0x92EAA0", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001074")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x92F920", Offset = "0x92EB20", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001071")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x92FA20", Offset = "0x92EC20", Length = "0x5F")]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexReplacement", Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.WeakReference`1<RegexReplacement>", typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), "System.Text.RegularExpressions.RegexOptions"}, ReturnType = "System.Text.RegularExpressions.RegexReplacement")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GCHandle), Member = "GetTargetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr), typeof(GCHandleType)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001072")]
	public void SetTarget(T target) { }

	[Address(RVA = "0x92FA80", Offset = "0x92EC80", Length = "0x10C")]
	[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = "InvokeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), "System.Security.Cryptography.X509Certificates.X509Chain", "System.Net.Security.SslPolicyErrors"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexReplacement", Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.WeakReference`1<RegexReplacement>", typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), "System.Text.RegularExpressions.RegexOptions"}, ReturnType = "System.Text.RegularExpressions.RegexReplacement")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "RegisterCallbackInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_FontAsset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "RegisterCallbackInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001073")]
	public bool TryGetTarget(out T target) { }

}

