namespace System.Runtime.InteropServices;

[Token(Token = "0x200044E")]
public static class Marshal
{
	[CompilerGenerated]
	[Token(Token = "0x2000451")]
	private sealed class <>c
	{
		[Token(Token = "0x4001229")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400122A")]
		public static Func<Dictionary`2<ValueTuple`2<Type, String>, ICustomMarshaler>> <>9__201_0; //Field offset: 0x8

		[Address(RVA = "0x13CE590", Offset = "0x13CD790", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001FF3")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FF4")]
		public <>c() { }

		[Address(RVA = "0x13CE1F0", Offset = "0x13CD3F0", Length = "0x86")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Object, System.Object>, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<System.ValueTuple`2<System.Object, System.Object>>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001FF5")]
		internal Dictionary<ValueTuple`2<Type, String>, ICustomMarshaler> <GetCustomMarshalerInstance>b__201_0() { }

	}

	[Token(Token = "0x2000450")]
	public class MarshalerInstanceKeyComparer : IEqualityComparer<ValueTuple`2<Type, String>>
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FF2")]
		public MarshalerInstanceKeyComparer() { }

		[Address(RVA = "0x13BD3B0", Offset = "0x13BC5B0", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.ValueTuple`2<System.Object, System.Object>), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Object, System.Object>)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001FF0")]
		public override bool Equals(ValueTuple<Type, String> lhs, ValueTuple<Type, String> rhs) { }

		[Address(RVA = "0x13BD410", Offset = "0x13BC610", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.ValueTuple`2<System.Object, System.Object>), Member = "GetHashCode", ReturnType = typeof(int))]
		[Token(Token = "0x6001FF1")]
		public override int GetHashCode(ValueTuple<Type, String> key) { }

	}

	[Token(Token = "0x200044F")]
	public sealed class SecureStringAllocator : MulticastDelegate
	{

		[Address(RVA = "0xC468A0", Offset = "0xC45AA0", Length = "0xA6")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FEE")]
		public SecureStringAllocator(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FEF")]
		public override IntPtr Invoke(int len) { }

	}

	[Token(Token = "0x4001225")]
	public static readonly int SystemMaxDBCSCharSize; //Field offset: 0x0
	[Token(Token = "0x4001226")]
	public static readonly int SystemDefaultCharSize; //Field offset: 0x4
	[Token(Token = "0x4001227")]
	internal static Dictionary<ValueTuple`2<Type, String>, ICustomMarshaler> MarshalerInstanceCache; //Field offset: 0x8
	[Token(Token = "0x4001228")]
	internal static readonly object MarshalerInstanceCacheLock; //Field offset: 0x10

	[Address(RVA = "0x13BD0C0", Offset = "0x13BC2C0", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "get_IsRunningOnWindows", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FED")]
	private static Marshal() { }

	[Address(RVA = "0x13BAEA0", Offset = "0x13BA0A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C9C0")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6001FB2")]
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[Address(RVA = "0x13BAEB0", Offset = "0x13BA0B0", Length = "0x52")]
	[CallerCount(Count = 40)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C9C0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6001FB3")]
	public static IntPtr AllocHGlobal(int cb) { }

	[Address(RVA = "0x13BAF10", Offset = "0x13BA110", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C9D0")]
	[Token(Token = "0x6001FE1")]
	private static IntPtr BufferToBSTR(Char* ptr, int slen) { }

	[Address(RVA = "0x13BAF20", Offset = "0x13BA120", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001FC4")]
	private static void ClearBSTR(IntPtr ptr) { }

	[Address(RVA = "0x13BAFF0", Offset = "0x13BA1F0", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001FC6")]
	private static void ClearUnicode(IntPtr ptr) { }

	[Address(RVA = "0x13BB100", Offset = "0x13BA300", Length = "0x145")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509", Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", "Mono.Btls.MonoBtlsX509Format"}, ReturnType = "Mono.Btls.MonoBtlsX509")]
	[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "SetClipboardText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "ReadCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(IntPtr), "unitytls_errorstate*"}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsBioMono", Member = "OnRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsBioMono", Member = "OnRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = "System.ValueTuple`2<Int32, Boolean>")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "UnmanagedRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D220")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001FB8")]
	public static void Copy(Byte[] source, int startIndex, IntPtr destination, int length) { }

	[Address(RVA = "0x13BB450", Offset = "0x13BA650", Length = "0xF3")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = "SetCiphers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int16[]", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D220")]
	[Calls(Type = typeof(Marshal), Member = "copy_to_unmanaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FB9")]
	public static void Copy(Int16[] source, int startIndex, IntPtr destination, int length) { }

	[Address(RVA = "0x13BB250", Offset = "0x13BA450", Length = "0xF3")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D220")]
	[Calls(Type = typeof(Marshal), Member = "copy_to_unmanaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FBA")]
	public static void Copy(Int32[] source, int startIndex, IntPtr destination, int length) { }

	[Address(RVA = "0x13BB350", Offset = "0x13BA550", Length = "0xF3")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D220")]
	[Calls(Type = typeof(Marshal), Member = "copy_to_unmanaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FBB")]
	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	[Address(RVA = "0x13BB850", Offset = "0x13BAA50", Length = "0xF2")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D1C0")]
	[Calls(Type = typeof(Marshal), Member = "copy_from_unmanaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FBE")]
	public static void Copy(IntPtr source, Byte[] destination, int startIndex, int length) { }

	[Address(RVA = "0x13BB550", Offset = "0x13BA750", Length = "0xF3")]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "BuildTailoringTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(TailoringInfo), typeof(Contraction[]&), typeof(Level2Map[]&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D1C0")]
	[Calls(Type = typeof(Marshal), Member = "copy_from_unmanaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FBF")]
	public static void Copy(IntPtr source, Char[] destination, int startIndex, int length) { }

	[Address(RVA = "0x13BB650", Offset = "0x13BA850", Length = "0xF3")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = "CopyIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(IntPtr)}, ReturnType = "System.String[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D1C0")]
	[Calls(Type = typeof(Marshal), Member = "copy_from_unmanaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FC0")]
	public static void Copy(IntPtr source, Int32[] destination, int startIndex, int length) { }

	[Address(RVA = "0x13BB750", Offset = "0x13BA950", Length = "0xF3")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = "CopyIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(IntPtr)}, ReturnType = "System.String[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D1C0")]
	[Calls(Type = typeof(Marshal), Member = "copy_from_unmanaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FC1")]
	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length) { }

	[Address(RVA = "0x13BD180", Offset = "0x13BC380", Length = "0x7D")]
	[CalledBy(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D1C0")]
	[Token(Token = "0x6001FBC")]
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	[Address(RVA = "0x13BD170", Offset = "0x13BC370", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D1C0")]
	[Token(Token = "0x6001FBD")]
	private static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, Void* fixed_destination_element) { }

	[Address(RVA = "0x13BD210", Offset = "0x13BC410", Length = "0x7D")]
	[CalledBy(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16[]), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr[]), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D220")]
	[Token(Token = "0x6001FB4")]
	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	[Address(RVA = "0x13BD290", Offset = "0x13BC490", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D220")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FB7")]
	internal static void copy_to_unmanaged(Byte[] source, int startIndex, IntPtr destination, int length) { }

	[Address(RVA = "0x13BD200", Offset = "0x13BC400", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D220")]
	[Token(Token = "0x6001FB5")]
	private static void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, Void* fixed_source_element) { }

	[Address(RVA = "0x13BB950", Offset = "0x13BAB50", Length = "0x5")]
	[CalledBy(Type = typeof(Variant), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CA00")]
	[Token(Token = "0x6001FC2")]
	public static void FreeBSTR(IntPtr ptr) { }

	[Address(RVA = "0x13BB960", Offset = "0x13BAB60", Length = "0x5")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CA10")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001FC3")]
	public static void FreeHGlobal(IntPtr hglobal) { }

	[Address(RVA = "0x13BB970", Offset = "0x13BAB70", Length = "0x860")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "InternalInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(Exception&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Object, System.Object>, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Object, System.Object>), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Object, System.Object>, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Object, System.Object>), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001FEC")]
	internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie) { }

	[Address(RVA = "0x13BC1F0", Offset = "0x13BB3F0", Length = "0x281")]
	[CalledBy(Type = typeof(Marshal), Member = "GetDelegateForFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "TDelegate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001FE7")]
	public static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t) { }

	[Address(RVA = "0x6FE8E0", Offset = "0x6FDAE0", Length = "0xD4")]
	[CalledBy(Type = "Unity.Burst.FunctionPointer`1", Member = "get_Invoke", ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "GetDelegateForFunctionPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FE8")]
	public static TDelegate GetDelegateForFunctionPointer(IntPtr ptr) { }

	[Address(RVA = "0x13BC1E0", Offset = "0x13BB3E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CAA0")]
	[Token(Token = "0x6001FE6")]
	private static Delegate GetDelegateForFunctionPointerInternal(IntPtr ptr, Type t) { }

	[Address(RVA = "0x6FEB50", Offset = "0x6FDD50", Length = "0xD6")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509LookupMono", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OSSpecificSynchronizationContext), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SendOrPostCallback), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDelegates", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsBioMono", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.IMonoBtlsBioMono"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSsl", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.MonoBtlsSslCtx"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSslCtx", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.MonoBtlsSslCtx+BoringSslCtxHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FEB")]
	public static IntPtr GetFunctionPointerForDelegate(TDelegate d) { }

	[Address(RVA = "0x13BC490", Offset = "0x13BB690", Length = "0x94")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001FEA")]
	public static IntPtr GetFunctionPointerForDelegate(Delegate d) { }

	[Address(RVA = "0x13BC480", Offset = "0x13BB680", Length = "0x5")]
	[CalledBy(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8B0")]
	[Token(Token = "0x6001FE9")]
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	[Address(RVA = "0x13BC530", Offset = "0x13BB730", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001FC8")]
	public static int GetHRForException(Exception e) { }

	[Address(RVA = "0x13BC540", Offset = "0x13BB740", Length = "0x5")]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CAD0")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001FCA")]
	public static int GetLastWin32Error() { }

	[Address(RVA = "0x13BC550", Offset = "0x13BB750", Length = "0x5")]
	[CalledBy(Type = "System.ComponentModel.ReferenceConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CBD0")]
	[Token(Token = "0x6001FC9")]
	public static bool IsComObject(object o) { }

	[Address(RVA = "0x13BC570", Offset = "0x13BB770", Length = "0x5")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSsl", Member = "PrintErrorsCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CC20")]
	[Token(Token = "0x6001FCC")]
	public static string PtrToStringAnsi(IntPtr ptr, int len) { }

	[Address(RVA = "0x13BC560", Offset = "0x13BB760", Length = "0x5")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.MonoBtlsSslError"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsError", Member = "GetErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsError", Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSsl", Member = "GetServerName", ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509Name", Member = "GetEntryOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CC10")]
	[Token(Token = "0x6001FCB")]
	public static string PtrToStringAnsi(IntPtr ptr) { }

	[Address(RVA = "0x13BC580", Offset = "0x13BB780", Length = "0x5")]
	[CalledBy(Type = typeof(SafePasswordHandle), Member = "Mono_DangerousGetString", ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "GetClipboardText", ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "PasteInstancesFromClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CC50")]
	[Token(Token = "0x6001FCD")]
	public static string PtrToStringUni(IntPtr ptr) { }

	[Address(RVA = "0x6FED50", Offset = "0x6FDF50", Length = "0xD4")]
	[CalledBy(Type = "Mono.Unity.UnityTls", Member = "get_NativeInterface", ReturnType = "Mono.Unity.UnityTls+unitytls_interface_struct")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FCF")]
	public static T PtrToStructure(IntPtr ptr) { }

	[Address(RVA = "0x13BC590", Offset = "0x13BB790", Length = "0x5")]
	[CalledBy(Type = "Discord.UserManager", Member = "get_Methods", ReturnType = "Discord.UserManager+FFIMethods")]
	[CalledBy(Type = "Discord.StorageManager", Member = "get_Methods", ReturnType = "Discord.StorageManager+FFIMethods")]
	[CalledBy(Type = "Discord.OverlayManager", Member = "get_Methods", ReturnType = "Discord.OverlayManager+FFIMethods")]
	[CalledBy(Type = "Discord.NetworkManager", Member = "get_Methods", ReturnType = "Discord.NetworkManager+FFIMethods")]
	[CalledBy(Type = "Discord.LobbyManager", Member = "get_Methods", ReturnType = "Discord.LobbyManager+FFIMethods")]
	[CalledBy(Type = "Discord.RelationshipManager", Member = "get_Methods", ReturnType = "Discord.RelationshipManager+FFIMethods")]
	[CalledBy(Type = "Discord.ImageManager", Member = "get_Methods", ReturnType = "Discord.ImageManager+FFIMethods")]
	[CalledBy(Type = "Discord.StoreManager", Member = "get_Methods", ReturnType = "Discord.StoreManager+FFIMethods")]
	[CalledBy(Type = "Discord.ApplicationManager", Member = "get_Methods", ReturnType = "Discord.ApplicationManager+FFIMethods")]
	[CalledBy(Type = "Discord.LobbySearchQuery", Member = "get_Methods", ReturnType = "Discord.LobbySearchQuery+FFIMethods")]
	[CalledBy(Type = "Discord.LobbyMemberTransaction", Member = "get_Methods", ReturnType = "Discord.LobbyMemberTransaction+FFIMethods")]
	[CalledBy(Type = "Discord.LobbyTransaction", Member = "get_Methods", ReturnType = "Discord.LobbyTransaction+FFIMethods")]
	[CalledBy(Type = "Discord.ActivityManager", Member = "get_Methods", ReturnType = "Discord.ActivityManager+FFIMethods")]
	[CalledBy(Type = typeof(Marshal), Member = "PtrToStructure", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CalledBy(Type = "Discord.AchievementManager", Member = "get_Methods", ReturnType = "Discord.AchievementManager+FFIMethods")]
	[CalledBy(Type = "Discord.Discord", Member = "get_Methods", ReturnType = "Discord.Discord+FFIMethods")]
	[CalledBy(Type = "Discord.VoiceManager", Member = "get_Methods", ReturnType = "Discord.VoiceManager+FFIMethods")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CC80")]
	[ComVisible(True)]
	[Token(Token = "0x6001FCE")]
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	[Address(RVA = "0x13BC5A0", Offset = "0x13BB7A0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FD0")]
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[Address(RVA = "0x13BC5F0", Offset = "0x13BB7F0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001FD1")]
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[Address(RVA = "0x13BC650", Offset = "0x13BB850", Length = "0x94")]
	[CalledBy(Type = typeof(Variant), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CE50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001FD3")]
	public static int Release(IntPtr pUnk) { }

	[Address(RVA = "0x13BC640", Offset = "0x13BB840", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CE50")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001FD2")]
	private static int ReleaseInternal(IntPtr pUnk) { }

	[Address(RVA = "0x13BC6F0", Offset = "0x13BB8F0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C9C0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FDC")]
	internal static IntPtr SecureStringGlobalAllocator(int len) { }

	[Address(RVA = "0x13BC780", Offset = "0x13BB980", Length = "0x133")]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "FillUserInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo", "ProcInfo&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SecureString), Member = "GetBuffer", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(SecureString), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C9D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001FDB")]
	public static IntPtr SecureStringToBSTR(SecureString s) { }

	[Address(RVA = "0x13BC8C0", Offset = "0x13BBAC0", Length = "0x164")]
	[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001FDE")]
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[Address(RVA = "0x13BCA30", Offset = "0x13BBC30", Length = "0x27E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813B4E10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SecureString), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(SecureString), Member = "GetBuffer", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001FDD")]
	internal static IntPtr SecureStringToUnicode(SecureString s, SecureStringAllocator allocator) { }

	[Address(RVA = "0x6FEFB0", Offset = "0x6FE1B0", Length = "0x78")]
	[CalledBy(Type = typeof(Kernel32), Member = "CopyFileUWP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FD5")]
	public static int SizeOf() { }

	[Address(RVA = "0x6FF370", Offset = "0x6FE570", Length = "0x102")]
	[CalledBy(Type = "Discord.Discord", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ulong)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FD6")]
	public static int SizeOf(T structure) { }

	[Address(RVA = "0x13BCCB0", Offset = "0x13BBEB0", Length = "0x5")]
	[CalledBy(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CE60")]
	[Token(Token = "0x6001FD4")]
	public static int SizeOf(Type t) { }

	[Address(RVA = "0x13BD370", Offset = "0x13BC570", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001FB6")]
	private static bool skip_fixed(Array array, int startIndex) { }

	[Address(RVA = "0x13BCCC0", Offset = "0x13BBEC0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CF50")]
	[Token(Token = "0x6001FD7")]
	private static IntPtr StringToHGlobalAnsi(Char* s, int length) { }

	[Address(RVA = "0x13BCCD0", Offset = "0x13BBED0", Length = "0x76")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsSsl", Member = "SetServerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509Lookup", Member = "AddDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Mono.Btls.MonoBtlsX509FileType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509VerifyParam", Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = "Mono.Btls.MonoBtlsX509VerifyParam")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509VerifyParam", Member = "SetHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D3F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CF50")]
	[Token(Token = "0x6001FD8")]
	public static IntPtr StringToHGlobalAnsi(string s) { }

	[Address(RVA = "0x13BCDD0", Offset = "0x13BBFD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D000")]
	[Token(Token = "0x6001FD9")]
	private static IntPtr StringToHGlobalUni(Char* s, int length) { }

	[Address(RVA = "0x13BCD50", Offset = "0x13BBF50", Length = "0x76")]
	[CalledBy(Type = typeof(SafePasswordHandle), Member = "CreateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(SafePasswordHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D3F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D000")]
	[Token(Token = "0x6001FDA")]
	public static IntPtr StringToHGlobalUni(string s) { }

	[Address(RVA = "0x6FF7C0", Offset = "0x6FE9C0", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FE0")]
	public static void StructureToPtr(T structure, IntPtr ptr, bool fDeleteOld) { }

	[Address(RVA = "0x13BCDE0", Offset = "0x13BBFE0", Length = "0x5")]
	[CalledBy(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D060")]
	[ComVisible(True)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6001FDF")]
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	[Address(RVA = "0x13BCDF0", Offset = "0x13BBFF0", Length = "0x5")]
	[CalledBy(Type = typeof(Marshal), Member = "UnsafeAddrOfPinnedArrayElement", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D180")]
	[Token(Token = "0x6001FE2")]
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	[Address(RVA = "0x6FF8B0", Offset = "0x6FEAB0", Length = "0x57")]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<ArraySegment`1<Byte>>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<ArraySegment`1<Byte>>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "UnsafeAddrOfPinnedArrayElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(IntPtr))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FE3")]
	public static IntPtr UnsafeAddrOfPinnedArrayElement(T[] arr, int index) { }

	[Address(RVA = "0x13BCE00", Offset = "0x13BC000", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001FE4")]
	public static void WriteByte(IntPtr ptr, int ofs, byte val) { }

	[Address(RVA = "0x13BCE30", Offset = "0x13BC030", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FE5")]
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	[Address(RVA = "0x13BCE80", Offset = "0x13BC080", Length = "0xFC")]
	[CalledBy(Type = "System.UriTypeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CA00")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001FC5")]
	public static void ZeroFreeBSTR(IntPtr s) { }

	[Address(RVA = "0x13BCF80", Offset = "0x13BC180", Length = "0x139")]
	[CalledBy(Type = typeof(SafePasswordHandle), Member = "FreeHandle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafePasswordHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.WebResponse", Member = "get_ResponseUri", ReturnType = "System.Uri")]
	[CalledBy(Type = "System.Net.UnsafeNclNativeMethods+SecureStringHelper", Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001FC7")]
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

}

