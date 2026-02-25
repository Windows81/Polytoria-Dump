namespace System.Security.Cryptography;

[Token(Token = "0x200031D")]
public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
{
	[Token(Token = "0x4000D5E")]
	private static object _lock; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D5F")]
	private IntPtr _handle; //Field offset: 0x10

	[Address(RVA = "0x134D480", Offset = "0x134C680", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801FF0E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001908")]
	private static RNGCryptoServiceProvider() { }

	[Address(RVA = "0x134D510", Offset = "0x134C710", Length = "0x60")]
	[CalledBy(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = "Mirror.Utils", Member = "GetTrueRandomUInt", ReturnType = typeof(uint))]
	[CalledBy(Type = "Mirror.SimpleWeb.ClientHandshake", Member = "TryHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection", "System.Uri"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.SimpleWeb.SendLoop", Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.SendLoop+Config"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.MaskHelper", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.Common", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C240")]
	[Calls(Type = typeof(RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001909")]
	public RNGCryptoServiceProvider() { }

	[Address(RVA = "0x134D110", Offset = "0x134C310", Length = "0x79")]
	[CalledBy(Type = typeof(Utils), Member = "get_StaticRandomNumberGenerator", ReturnType = typeof(RNGCryptoServiceProvider))]
	[CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600190A")]
	private void Check() { }

	[Address(RVA = "0x10BBD80", Offset = "0x10BAF80", Length = "0x8")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001911")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x134D190", Offset = "0x134C390", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_set_default_thread_affinity")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001910")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x134D240", Offset = "0x134C440", Length = "0x1F5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C1C0")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600190F")]
	public virtual void GetBytes(Byte[] data) { }

	[Address(RVA = "0x134D440", Offset = "0x134C640", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_set_default_thread_affinity")]
	[DeduplicatedMethod]
	[Token(Token = "0x600190E")]
	private static void RngClose(IntPtr handle) { }

	[Address(RVA = "0x134D450", Offset = "0x134C650", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C1C0")]
	[Token(Token = "0x600190D")]
	private static IntPtr RngGetBytes(IntPtr handle, Byte* data, IntPtr data_length) { }

	[Address(RVA = "0x134D460", Offset = "0x134C660", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C240")]
	[Token(Token = "0x600190C")]
	private static IntPtr RngInitialize(Byte* seed, IntPtr seed_length) { }

	[Address(RVA = "0x134D470", Offset = "0x134C670", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801FF0E0")]
	[Token(Token = "0x600190B")]
	private static bool RngOpen() { }

}

