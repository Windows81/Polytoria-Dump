namespace Mono.Net.Security.Private;

[Token(Token = "0x2000066")]
internal static class CallbackHelpers
{
	[CompilerGenerated]
	[Token(Token = "0x2000067")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012D")]
		public RemoteCertificateValidationCallback callback; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600018A")]
		public <>c__DisplayClass0_0() { }

		[Address(RVA = "0x16010C0", Offset = "0x16002C0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600018B")]
		internal bool <PublicToMono>b__0(string h, X509Certificate c, X509Chain ch, MonoSslPolicyErrors e) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000068")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012E")]
		public MonoLocalCertificateSelectionCallback callback; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600018C")]
		public <>c__DisplayClass6_0() { }

		[Address(RVA = "0x16010C0", Offset = "0x16002C0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600018D")]
		internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, String[] ai) { }

	}


	[Address(RVA = "0x15EDF60", Offset = "0x15ED160", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000189")]
	internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

	[Address(RVA = "0x15EE020", Offset = "0x15ED220", Length = "0xBA")]
	[CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback), typeof(LocalCertificateSelectionCallback)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SslStream), Member = "SetAndVerifyValidationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoRemoteCertificateValidationCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000188")]
	internal static MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback) { }

}

