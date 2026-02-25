namespace Mono.Unity;

[Token(Token = "0x200000A")]
internal static class UnityTls
{
	[Token(Token = "0x2000017")]
	internal enum unitytls_ciphersuite
	{
		UNITYTLS_CIPHERSUITE_INVALID = 16777215,
	}

	[Token(Token = "0x200000B")]
	internal enum unitytls_error_code
	{
		UNITYTLS_SUCCESS = 0,
		UNITYTLS_INVALID_ARGUMENT = 1,
		UNITYTLS_INVALID_FORMAT = 2,
		UNITYTLS_INVALID_PASSWORD = 3,
		UNITYTLS_INVALID_STATE = 4,
		UNITYTLS_BUFFER_OVERFLOW = 5,
		UNITYTLS_OUT_OF_MEMORY = 6,
		UNITYTLS_INTERNAL_ERROR = 7,
		UNITYTLS_NOT_SUPPORTED = 8,
		UNITYTLS_ENTROPY_SOURCE_FAILED = 9,
		UNITYTLS_STREAM_CLOSED = 10,
		UNITYTLS_DER_PARSE_ERROR = 11,
		UNITYTLS_KEY_PARSE_ERROR = 12,
		UNITYTLS_SSL_ERROR = 13,
		UNITYTLS_USER_CUSTOM_ERROR_START = 1048576,
		UNITYTLS_USER_WOULD_BLOCK = 1048577,
		UNITYTLS_USER_WOULD_BLOCK_READ = 1048578,
		UNITYTLS_USER_WOULD_BLOCK_WRITE = 1048579,
		UNITYTLS_USER_READ_FAILED = 1048580,
		UNITYTLS_USER_WRITE_FAILED = 1048581,
		UNITYTLS_USER_UNKNOWN_ERROR = 1048582,
		UNITYTLS_SSL_NEEDS_VERIFY = 1048583,
		UNITYTLS_HANDSHAKE_STEP = 1048584,
		UNITYTLS_USER_CUSTOM_ERROR_END = 2097152,
	}

	[Token(Token = "0x200000D")]
	internal struct unitytls_errorstate
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002C")]
		private uint magic; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400002D")]
		public unitytls_error_code code; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400002E")]
		private ulong reserved; //Field offset: 0x8

	}

	[Token(Token = "0x2000020")]
	internal class unitytls_interface_struct
	{
		[Token(Token = "0x2000021")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_errorstate_create_t : MulticastDelegate
		{

			[Address(RVA = "0xC42E50", Offset = "0xC42050", Length = "0xA5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000037")]
			public unitytls_errorstate_create_t(object object, IntPtr method) { }

			[Address(RVA = "0xC42CB0", Offset = "0xC41EB0", Length = "0x2B")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000038")]
			public override unitytls_errorstate Invoke() { }

		}

		[Token(Token = "0x2000022")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_errorstate_raise_error_t : MulticastDelegate
		{

			[Address(RVA = "0x16061E0", Offset = "0x16053E0", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000039")]
			public unitytls_errorstate_raise_error_t(object object, IntPtr method) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600003A")]
			public override void Invoke(unitytls_errorstate* errorState, unitytls_error_code errorCode) { }

		}

		[Token(Token = "0x2000026")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_key_free_t : MulticastDelegate
		{

			[Address(RVA = "0x38E330", Offset = "0x38D530", Length = "0xB4")]
			[CallerCount(Count = 5)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000041")]
			public unitytls_key_free_t(object object, IntPtr method) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000042")]
			public override void Invoke(unitytls_key* key) { }

		}

		[Token(Token = "0x2000023")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_key_get_ref_t : MulticastDelegate
		{

			[Address(RVA = "0x16062A0", Offset = "0x16054A0", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600003B")]
			public unitytls_key_get_ref_t(object object, IntPtr method) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600003C")]
			public override unitytls_key_ref Invoke(unitytls_key* key, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x2000024")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_key_parse_der_t : MulticastDelegate
		{

			[Address(RVA = "0x1606360", Offset = "0x1605560", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600003D")]
			public unitytls_key_parse_der_t(object object, IntPtr method) { }

			[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600003E")]
			public override unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x2000025")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_key_parse_pem_t : MulticastDelegate
		{

			[Address(RVA = "0x1606360", Offset = "0x1605560", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600003F")]
			public unitytls_key_parse_pem_t(object object, IntPtr method) { }

			[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000040")]
			public override unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x200003E")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_random_generate_bytes_t : MulticastDelegate
		{

			[Address(RVA = "0x1606420", Offset = "0x1605620", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000071")]
			public unitytls_random_generate_bytes_t(object object, IntPtr method) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000072")]
			public override void Invoke(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x2000031")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_create_client_t : MulticastDelegate
		{

			[Address(RVA = "0x16065A0", Offset = "0x16057A0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000057")]
			public unitytls_tlsctx_create_client_t(object object, IntPtr method) { }

			[Address(RVA = "0x3945F0", Offset = "0x3937F0", Length = "0x51")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000058")]
			public override unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, Byte* cn, IntPtr cnLen, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x2000030")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_create_server_t : MulticastDelegate
		{

			[Address(RVA = "0x16065A0", Offset = "0x16057A0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000055")]
			public unitytls_tlsctx_create_server_t(object object, IntPtr method) { }

			[Address(RVA = "0x3945F0", Offset = "0x3937F0", Length = "0x51")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000056")]
			public override unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x200003D")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_free_t : MulticastDelegate
		{

			[Address(RVA = "0x38E330", Offset = "0x38D530", Length = "0xB4")]
			[CallerCount(Count = 5)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600006F")]
			public unitytls_tlsctx_free_t(object object, IntPtr method) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000070")]
			public override void Invoke(unitytls_tlsctx* ctx) { }

		}

		[Token(Token = "0x2000037")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_get_ciphersuite_t : MulticastDelegate
		{

			[Address(RVA = "0x1606650", Offset = "0x1605850", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000063")]
			public unitytls_tlsctx_get_ciphersuite_t(object object, IntPtr method) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000064")]
			public override unitytls_ciphersuite Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x2000038")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_get_protocol_t : MulticastDelegate
		{

			[Address(RVA = "0x1606650", Offset = "0x1605850", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000065")]
			public unitytls_tlsctx_get_protocol_t(object object, IntPtr method) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000066")]
			public override unitytls_protocol Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x200003C")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_notify_close_t : MulticastDelegate
		{

			[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
			[CallerCount(Count = 13)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600006D")]
			public unitytls_tlsctx_notify_close_t(object object, IntPtr method) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600006E")]
			public override void Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x2000039")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_process_handshake_t : MulticastDelegate
		{

			[Address(RVA = "0x1606650", Offset = "0x1605850", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000067")]
			public unitytls_tlsctx_process_handshake_t(object object, IntPtr method) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000068")]
			public override unitytls_x509verify_result Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x200003A")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_read_t : MulticastDelegate
		{

			[Address(RVA = "0x12CD4C0", Offset = "0x12CC6C0", Length = "0xB5")]
			[CallerCount(Count = 5)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000069")]
			public unitytls_tlsctx_read_t(object object, IntPtr method) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600006A")]
			public override IntPtr Invoke(unitytls_tlsctx* ctx, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x2000032")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate
		{

			[Address(RVA = "0x1606710", Offset = "0x1605910", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000059")]
			public unitytls_tlsctx_server_require_client_authentication_t(object object, IntPtr method) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600005A")]
			public override void Invoke(unitytls_tlsctx* ctx, unitytls_x509list_ref clientAuthCAList, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x2000033")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate
		{

			[Address(RVA = "0x16067D0", Offset = "0x16059D0", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600005B")]
			public unitytls_tlsctx_set_certificate_callback_t(object object, IntPtr method) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600005C")]
			public override void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_certificate_callback cb, Void* userData, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x2000036")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate
		{

			[Address(RVA = "0x16067D0", Offset = "0x16059D0", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000061")]
			public unitytls_tlsctx_set_supported_ciphersuites_t(object object, IntPtr method) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000062")]
			public override void Invoke(unitytls_tlsctx* ctx, unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x2000034")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_set_trace_callback_t : MulticastDelegate
		{

			[Address(RVA = "0x16067D0", Offset = "0x16059D0", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600005D")]
			public unitytls_tlsctx_set_trace_callback_t(object object, IntPtr method) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600005E")]
			public override void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_trace_callback cb, Void* userData, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x2000040")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_set_trace_level_t : MulticastDelegate
		{

			[Address(RVA = "0x16061E0", Offset = "0x16053E0", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000075")]
			public unitytls_tlsctx_set_trace_level_t(object object, IntPtr method) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000076")]
			public override void Invoke(unitytls_tlsctx* ctx, unitytls_log_level level) { }

		}

		[Token(Token = "0x2000035")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate
		{

			[Address(RVA = "0x16067D0", Offset = "0x16059D0", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600005F")]
			public unitytls_tlsctx_set_x509verify_callback_t(object object, IntPtr method) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000060")]
			public override void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x200003B")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_tlsctx_write_t : MulticastDelegate
		{

			[Address(RVA = "0x12CD4C0", Offset = "0x12CC6C0", Length = "0xB5")]
			[CallerCount(Count = 5)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600006B")]
			public unitytls_tlsctx_write_t(object object, IntPtr method) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600006C")]
			public override IntPtr Invoke(unitytls_tlsctx* ctx, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x2000027")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509_export_der_t : MulticastDelegate
		{

			[Address(RVA = "0x1606950", Offset = "0x1605B50", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6000043")]
			public unitytls_x509_export_der_t(object object, IntPtr method) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000044")]
			public override IntPtr Invoke(unitytls_x509_ref cert, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x200002C")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509list_append_der_t : MulticastDelegate
		{

			[Address(RVA = "0x16067D0", Offset = "0x16059D0", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600004D")]
			public unitytls_x509list_append_der_t(object object, IntPtr method) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600004E")]
			public override void Invoke(unitytls_x509list* list, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x200002B")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509list_append_t : MulticastDelegate
		{

			[Address(RVA = "0x1606710", Offset = "0x1605910", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600004B")]
			public unitytls_x509list_append_t(object object, IntPtr method) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600004C")]
			public override void Invoke(unitytls_x509list* list, unitytls_x509_ref cert, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x200002A")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509list_create_t : MulticastDelegate
		{

			[Address(RVA = "0x102BE50", Offset = "0x102B050", Length = "0xB4")]
			[CallerCount(Count = 6)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000049")]
			public unitytls_x509list_create_t(object object, IntPtr method) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600004A")]
			public override unitytls_x509list* Invoke(unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x200002D")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509list_free_t : MulticastDelegate
		{

			[Address(RVA = "0x38E330", Offset = "0x38D530", Length = "0xB4")]
			[CallerCount(Count = 5)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600004F")]
			public unitytls_x509list_free_t(object object, IntPtr method) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000050")]
			public override void Invoke(unitytls_x509list* list) { }

		}

		[Token(Token = "0x2000028")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509list_get_ref_t : MulticastDelegate
		{

			[Address(RVA = "0x16062A0", Offset = "0x16054A0", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000045")]
			public unitytls_x509list_get_ref_t(object object, IntPtr method) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000046")]
			public override unitytls_x509list_ref Invoke(unitytls_x509list* list, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x2000029")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509list_get_x509_t : MulticastDelegate
		{

			[Address(RVA = "0x1606A00", Offset = "0x1605C00", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6000047")]
			public unitytls_x509list_get_x509_t(object object, IntPtr method) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000048")]
			public override unitytls_x509_ref Invoke(unitytls_x509list_ref list, IntPtr index, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x200002E")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509verify_default_ca_t : MulticastDelegate
		{

			[Address(RVA = "0x1606B70", Offset = "0x1605D70", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6000051")]
			public unitytls_x509verify_default_ca_t(object object, IntPtr method) { }

			[Address(RVA = "0x3359C0", Offset = "0x334BC0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000052")]
			public override unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x200002F")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509verify_explicit_ca_t : MulticastDelegate
		{

			[Address(RVA = "0x1606C20", Offset = "0x1605E20", Length = "0x10F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = "System.Net.Http.Headers.HttpHeaders+<GetEnumerator>d__19", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000053")]
			public unitytls_x509verify_explicit_ca_t(object object, IntPtr method) { }

			[Address(RVA = "0x335B80", Offset = "0x334D80", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000054")]
			public override unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, unitytls_x509list_ref trustCA, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

		}

		[Token(Token = "0x200003F")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		internal sealed class unitytls_x509verify_result_to_string_t : MulticastDelegate
		{

			[Address(RVA = "0xC468A0", Offset = "0xC45AA0", Length = "0xA6")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000073")]
			public unitytls_x509verify_result_to_string_t(object object, IntPtr method) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000074")]
			public override Char* Invoke(unitytls_x509verify_result v) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400005F")]
		public readonly ulong UNITYTLS_INVALID_HANDLE; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000060")]
		public readonly unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000061")]
		public unitytls_errorstate_create_t unitytls_errorstate_create; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000062")]
		public unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000063")]
		public unitytls_key_get_ref_t unitytls_key_get_ref; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000064")]
		public unitytls_key_parse_der_t unitytls_key_parse_der; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000065")]
		public unitytls_key_parse_pem_t unitytls_key_parse_pem; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000066")]
		public unitytls_key_free_t unitytls_key_free; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000067")]
		public unitytls_x509_export_der_t unitytls_x509_export_der; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000068")]
		public unitytls_x509list_get_ref_t unitytls_x509list_get_ref; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000069")]
		public unitytls_x509list_get_x509_t unitytls_x509list_get_x509; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400006A")]
		public unitytls_x509list_create_t unitytls_x509list_create; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400006B")]
		public unitytls_x509list_append_t unitytls_x509list_append; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400006C")]
		public unitytls_x509list_append_der_t unitytls_x509list_append_der; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400006D")]
		public unitytls_x509list_append_der_t unitytls_x509list_append_pem; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400006E")]
		public unitytls_x509list_free_t unitytls_x509list_free; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400006F")]
		public unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000070")]
		public unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000071")]
		public unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000072")]
		public unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000073")]
		public unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000074")]
		public unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000075")]
		public unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4000076")]
		public unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback; //Field offset: 0xC8
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4000077")]
		public unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4000078")]
		public unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite; //Field offset: 0xD8
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4000079")]
		public unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol; //Field offset: 0xE0
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x400007A")]
		public unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake; //Field offset: 0xE8
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x400007B")]
		public unitytls_tlsctx_read_t unitytls_tlsctx_read; //Field offset: 0xF0
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x400007C")]
		public unitytls_tlsctx_write_t unitytls_tlsctx_write; //Field offset: 0xF8
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x400007D")]
		public unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close; //Field offset: 0x100
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x400007E")]
		public unitytls_tlsctx_free_t unitytls_tlsctx_free; //Field offset: 0x108
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x400007F")]
		public unitytls_random_generate_bytes_t unitytls_random_generate_bytes; //Field offset: 0x110
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x4000080")]
		public unitytls_x509verify_result_to_string_t unitytls_x509verify_result_to_string; //Field offset: 0x118
		[FieldOffset(Offset = "0x120")]
		[Token(Token = "0x4000081")]
		public unitytls_tlsctx_set_trace_level_t unitytls_tlsctx_set_trace_level; //Field offset: 0x120

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000036")]
		public unitytls_interface_struct() { }

	}

	[Token(Token = "0x200000E")]
	internal struct unitytls_key
	{

	}

	[Token(Token = "0x200000F")]
	internal struct unitytls_key_ref
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002F")]
		public ulong handle; //Field offset: 0x0

	}

	[Token(Token = "0x200000C")]
	internal enum unitytls_log_level
	{
		UNITYTLS_LOGLEVEL_MIN = 0,
		UNITYTLS_LOGLEVEL_FATAL = 0,
		UNITYTLS_LOGLEVEL_ERROR = 1,
		UNITYTLS_LOGLEVEL_WARN = 2,
		UNITYTLS_LOGLEVEL_INFO = 3,
		UNITYTLS_LOGLEVEL_DEBUG = 4,
		UNITYTLS_LOGLEVEL_TRACE = 5,
		UNITYTLS_LOGLEVEL_MAX = 5,
	}

	[Token(Token = "0x2000018")]
	internal enum unitytls_protocol
	{
		UNITYTLS_PROTOCOL_TLS_1_0 = 0,
		UNITYTLS_PROTOCOL_TLS_1_1 = 1,
		UNITYTLS_PROTOCOL_TLS_1_2 = 2,
		UNITYTLS_PROTOCOL_INVALID = 3,
	}

	[Token(Token = "0x2000015")]
	internal struct unitytls_tlsctx
	{

	}

	[Token(Token = "0x200001F")]
	internal struct unitytls_tlsctx_callbacks
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005C")]
		public unitytls_tlsctx_read_callback read; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400005D")]
		public unitytls_tlsctx_write_callback write; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400005E")]
		public Void* data; //Field offset: 0x10

	}

	[Token(Token = "0x200001D")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class unitytls_tlsctx_certificate_callback : MulticastDelegate
	{

		[Address(RVA = "0x16064E0", Offset = "0x16056E0", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000032")]
		public unitytls_tlsctx_certificate_callback(object object, IntPtr method) { }

		[Address(RVA = "0x335F30", Offset = "0x335130", Length = "0x67")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000033")]
		public override void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	}

	[Token(Token = "0x2000019")]
	internal struct unitytls_tlsctx_protocolrange
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005A")]
		public unitytls_protocol min; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400005B")]
		public unitytls_protocol max; //Field offset: 0x4

	}

	[Token(Token = "0x200001B")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class unitytls_tlsctx_read_callback : MulticastDelegate
	{

		[Address(RVA = "0x12CD4C0", Offset = "0x12CC6C0", Length = "0xB5")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600002E")]
		public unitytls_tlsctx_read_callback(object object, IntPtr method) { }

		[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002F")]
		public override IntPtr Invoke(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	}

	[Token(Token = "0x200001C")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class unitytls_tlsctx_trace_callback : MulticastDelegate
	{

		[Address(RVA = "0x16067D0", Offset = "0x16059D0", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000030")]
		public unitytls_tlsctx_trace_callback(object object, IntPtr method) { }

		[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000031")]
		public override void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* traceMessage, IntPtr traceMessageLen) { }

	}

	[Token(Token = "0x200001A")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class unitytls_tlsctx_write_callback : MulticastDelegate
	{

		[Address(RVA = "0x12CD4C0", Offset = "0x12CC6C0", Length = "0xB5")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600002C")]
		public unitytls_tlsctx_write_callback(object object, IntPtr method) { }

		[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002D")]
		public override IntPtr Invoke(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	}

	[Token(Token = "0x200001E")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class unitytls_tlsctx_x509verify_callback : MulticastDelegate
	{

		[Address(RVA = "0x1606890", Offset = "0x1605A90", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000034")]
		public unitytls_tlsctx_x509verify_callback(object object, IntPtr method) { }

		[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000035")]
		public override unitytls_x509verify_result Invoke(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	}

	[Token(Token = "0x2000010")]
	internal struct unitytls_x509_ref
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000030")]
		public ulong handle; //Field offset: 0x0

	}

	[Token(Token = "0x2000011")]
	internal struct unitytls_x509list
	{

	}

	[Token(Token = "0x2000012")]
	internal struct unitytls_x509list_ref
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000031")]
		public ulong handle; //Field offset: 0x0

	}

	[Token(Token = "0x2000016")]
	internal struct unitytls_x509name
	{

	}

	[Token(Token = "0x2000014")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class unitytls_x509verify_callback : MulticastDelegate
	{

		[Address(RVA = "0x1606AB0", Offset = "0x1605CB0", Length = "0xB5")]
		[CalledBy(Type = typeof(UnityTlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600002A")]
		public unitytls_x509verify_callback(object object, IntPtr method) { }

		[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002B")]
		public override unitytls_x509verify_result Invoke(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

	}

	[Flags]
	[Token(Token = "0x2000013")]
	internal enum unitytls_x509verify_result
	{
		UNITYTLS_X509VERIFY_SUCCESS = 0,
		UNITYTLS_X509VERIFY_NOT_DONE = 2147483648,
		UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295,
		UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1,
		UNITYTLS_X509VERIFY_FLAG_REVOKED = 2,
		UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4,
		UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8,
		UNITYTLS_X509VERIFY_FLAG_BADCRL_NOT_TRUSTED = 16,
		UNITYTLS_X509VERIFY_FLAG_BADCRL_EXPIRED = 32,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_MISSING = 64,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_SKIP_VERIFY = 128,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_OTHER = 256,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_FUTURE = 512,
		UNITYTLS_X509VERIFY_FLAG_BADCRL_FUTURE = 1024,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_KEY_USAGE = 2048,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_EXT_KEY_USAGE = 4096,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_NS_CERT_TYPE = 8192,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_MD = 16384,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_PK = 32768,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_KEY = 65536,
		UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_MD = 131072,
		UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_PK = 262144,
		UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_KEY = 524288,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608,
		UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728,
	}

	[Token(Token = "0x4000009")]
	private static unitytls_interface_struct marshalledInterface; //Field offset: 0x0

	[Token(Token = "0x17000008")]
	public static bool IsSupported
	{
		[Address(RVA = "0x1605020", Offset = "0x1604220", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000028")]
		 get { } //Length: 22
	}

	[Token(Token = "0x17000009")]
	public static unitytls_interface_struct NativeInterface
	{
		[Address(RVA = "0x1605040", Offset = "0x1604240", Length = "0xCE")]
		[CallerCount(Count = 77)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180223080")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000029")]
		 get { } //Length: 206
	}

	[Address(RVA = "0x1605020", Offset = "0x1604220", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000028")]
	public static bool get_IsSupported() { }

	[Address(RVA = "0x1605040", Offset = "0x1604240", Length = "0xCE")]
	[CallerCount(Count = 77)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180223080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000029")]
	public static unitytls_interface_struct get_NativeInterface() { }

	[Address(RVA = "0x1605010", Offset = "0x1604210", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180223080")]
	[Token(Token = "0x6000027")]
	private static IntPtr GetUnityTlsInterface() { }

}

