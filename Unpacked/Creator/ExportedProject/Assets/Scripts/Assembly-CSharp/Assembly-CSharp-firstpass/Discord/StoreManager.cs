namespace Discord;

[Token(Token = "0x20002CC")]
public class StoreManager
{
	[Token(Token = "0x20002E1")]
	internal sealed class EntitlementCreateHandler : MulticastDelegate
	{

		[Address(RVA = "0x38E5F0", Offset = "0x38D7F0", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001403")]
		public EntitlementCreateHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3A4F40", Offset = "0x3A4140", Length = "0x81")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6001405")]
		public override IAsyncResult BeginInvoke(ref Entitlement entitlement, AsyncCallback callback, object object) { }

		[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001406")]
		public override void EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001404")]
		public override void Invoke(ref Entitlement entitlement) { }

	}

	[Token(Token = "0x20002E2")]
	internal sealed class EntitlementDeleteHandler : MulticastDelegate
	{

		[Address(RVA = "0x38E5F0", Offset = "0x38D7F0", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001407")]
		public EntitlementDeleteHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3A4FD0", Offset = "0x3A41D0", Length = "0x81")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6001409")]
		public override IAsyncResult BeginInvoke(ref Entitlement entitlement, AsyncCallback callback, object object) { }

		[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x600140A")]
		public override void EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001408")]
		public override void Invoke(ref Entitlement entitlement) { }

	}

	[Token(Token = "0x20002DF")]
	internal sealed class FetchEntitlementsHandler : MulticastDelegate
	{

		[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60013FB")]
		public FetchEntitlementsHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3A5210", Offset = "0x3A4410", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x60013FD")]
		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x60013FE")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013FC")]
		public override void Invoke(Result result) { }

	}

	[Token(Token = "0x20002DE")]
	internal sealed class FetchSkusHandler : MulticastDelegate
	{

		[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60013F7")]
		public FetchSkusHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3A5320", Offset = "0x3A4520", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x60013F9")]
		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x60013FA")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013F8")]
		public override void Invoke(Result result) { }

	}

	[Token(Token = "0x20002CD")]
	public struct FFIEvents
	{
		[Token(Token = "0x20002CE")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class EntitlementCreateHandler : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013BB")]
			public EntitlementCreateHandler(object object, IntPtr method) { }

			[Address(RVA = "0x3A4EA0", Offset = "0x3A40A0", Length = "0x91")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60013BD")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, ref Entitlement entitlement, AsyncCallback callback, object object) { }

			[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013BE")]
			public override void EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013BC")]
			public override void Invoke(IntPtr ptr, ref Entitlement entitlement) { }

		}

		[Token(Token = "0x20002CF")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class EntitlementDeleteHandler : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013BF")]
			public EntitlementDeleteHandler(object object, IntPtr method) { }

			[Address(RVA = "0x3A5060", Offset = "0x3A4260", Length = "0x91")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60013C1")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, ref Entitlement entitlement, AsyncCallback callback, object object) { }

			[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013C2")]
			public override void EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013C0")]
			public override void Invoke(IntPtr ptr, ref Entitlement entitlement) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007FE")]
		internal EntitlementCreateHandler OnEntitlementCreate; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007FF")]
		internal EntitlementDeleteHandler OnEntitlementDelete; //Field offset: 0x8

	}

	[Token(Token = "0x20002D0")]
	public struct FFIMethods
	{
		[Token(Token = "0x20002D8")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class CountEntitlementsMethod : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013DF")]
			public CountEntitlementsMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391AC0", Offset = "0x390CC0", Length = "0x75")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013E1")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

			[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013E2")]
			public override void EndInvoke(ref int count, IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013E0")]
			public override void Invoke(IntPtr methodsPtr, ref int count) { }

		}

		[Token(Token = "0x20002D3")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class CountSkusMethod : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013CB")]
			public CountSkusMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391AC0", Offset = "0x390CC0", Length = "0x75")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013CD")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

			[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013CE")]
			public override void EndInvoke(ref int count, IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013CC")]
			public override void Invoke(IntPtr methodsPtr, ref int count) { }

		}

		[Token(Token = "0x20002D6")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FetchEntitlementsCallback : MulticastDelegate
		{

			[Address(RVA = "0x38DC70", Offset = "0x38CE70", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013D7")]
			public FetchEntitlementsCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3A5180", Offset = "0x3A4380", Length = "0x8B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60013D9")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013DA")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013D8")]
			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[Token(Token = "0x20002D7")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FetchEntitlementsMethod : MulticastDelegate
		{

			[Address(RVA = "0x391240", Offset = "0x390440", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013DB")]
			public FetchEntitlementsMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3911C0", Offset = "0x3903C0", Length = "0x76")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013DD")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, FetchEntitlementsCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013DE")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013DC")]
			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, FetchEntitlementsCallback callback) { }

		}

		[Token(Token = "0x20002D1")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FetchSkusCallback : MulticastDelegate
		{

			[Address(RVA = "0x38DC70", Offset = "0x38CE70", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013C3")]
			public FetchSkusCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3A5290", Offset = "0x3A4490", Length = "0x8B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60013C5")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013C6")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013C4")]
			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[Token(Token = "0x20002D2")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FetchSkusMethod : MulticastDelegate
		{

			[Address(RVA = "0x391240", Offset = "0x390440", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013C7")]
			public FetchSkusMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3911C0", Offset = "0x3903C0", Length = "0x76")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013C9")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, FetchSkusCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013CA")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013C8")]
			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, FetchSkusCallback callback) { }

		}

		[Token(Token = "0x20002DA")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetEntitlementAtMethod : MulticastDelegate
		{

			[Address(RVA = "0x391E10", Offset = "0x391010", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013E7")]
			public GetEntitlementAtMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A5520", Offset = "0x3A4720", Length = "0xA1")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60013E9")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref Entitlement entitlement, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391B40", Offset = "0x390D40", Length = "0x2F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013EA")]
			public override Result EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013E8")]
			public override Result Invoke(IntPtr methodsPtr, int index, ref Entitlement entitlement) { }

		}

		[Token(Token = "0x20002D9")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetEntitlementMethod : MulticastDelegate
		{

			[Address(RVA = "0x397000", Offset = "0x396200", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013E3")]
			public GetEntitlementMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A55D0", Offset = "0x3A47D0", Length = "0xA1")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60013E5")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long entitlementId, ref Entitlement entitlement, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391B40", Offset = "0x390D40", Length = "0x2F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013E6")]
			public override Result EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013E4")]
			public override Result Invoke(IntPtr methodsPtr, long entitlementId, ref Entitlement entitlement) { }

		}

		[Token(Token = "0x20002D5")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetSkuAtMethod : MulticastDelegate
		{

			[Address(RVA = "0x391E10", Offset = "0x391010", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013D3")]
			public GetSkuAtMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A5830", Offset = "0x3A4A30", Length = "0xA1")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60013D5")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref Sku sku, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391B40", Offset = "0x390D40", Length = "0x2F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013D6")]
			public override Result EndInvoke(ref Sku sku, IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013D4")]
			public override Result Invoke(IntPtr methodsPtr, int index, ref Sku sku) { }

		}

		[Token(Token = "0x20002D4")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetSkuMethod : MulticastDelegate
		{

			[Address(RVA = "0x397000", Offset = "0x396200", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013CF")]
			public GetSkuMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A58E0", Offset = "0x3A4AE0", Length = "0xA1")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60013D1")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long skuId, ref Sku sku, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391B40", Offset = "0x390D40", Length = "0x2F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013D2")]
			public override Result EndInvoke(ref Sku sku, IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013D0")]
			public override Result Invoke(IntPtr methodsPtr, long skuId, ref Sku sku) { }

		}

		[Token(Token = "0x20002DB")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class HasSkuEntitlementMethod : MulticastDelegate
		{

			[Address(RVA = "0x397000", Offset = "0x396200", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013EB")]
			public HasSkuEntitlementMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A5AF0", Offset = "0x3A4CF0", Length = "0x85")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013ED")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long skuId, ref bool hasEntitlement, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391B40", Offset = "0x390D40", Length = "0x2F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013EE")]
			public override Result EndInvoke(ref bool hasEntitlement, IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013EC")]
			public override Result Invoke(IntPtr methodsPtr, long skuId, ref bool hasEntitlement) { }

		}

		[Token(Token = "0x20002DC")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class StartPurchaseCallback : MulticastDelegate
		{

			[Address(RVA = "0x38DC70", Offset = "0x38CE70", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013EF")]
			public StartPurchaseCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3AAF60", Offset = "0x3AA160", Length = "0x8B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60013F1")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013F2")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013F0")]
			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[Token(Token = "0x20002DD")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class StartPurchaseMethod : MulticastDelegate
		{

			[Address(RVA = "0x38DEF0", Offset = "0x38D0F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013F3")]
			public StartPurchaseMethod(object object, IntPtr method) { }

			[Address(RVA = "0x38DE50", Offset = "0x38D050", Length = "0x92")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013F5")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long skuId, IntPtr callbackData, StartPurchaseCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60013F6")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60013F4")]
			public override void Invoke(IntPtr methodsPtr, long skuId, IntPtr callbackData, StartPurchaseCallback callback) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000800")]
		internal FetchSkusMethod FetchSkus; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000801")]
		internal CountSkusMethod CountSkus; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000802")]
		internal GetSkuMethod GetSku; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000803")]
		internal GetSkuAtMethod GetSkuAt; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000804")]
		internal FetchEntitlementsMethod FetchEntitlements; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000805")]
		internal CountEntitlementsMethod CountEntitlements; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000806")]
		internal GetEntitlementMethod GetEntitlement; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000807")]
		internal GetEntitlementAtMethod GetEntitlementAt; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000808")]
		internal HasSkuEntitlementMethod HasSkuEntitlement; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000809")]
		internal StartPurchaseMethod StartPurchase; //Field offset: 0x48

	}

	[Token(Token = "0x20002E0")]
	internal sealed class StartPurchaseHandler : MulticastDelegate
	{

		[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60013FF")]
		public StartPurchaseHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3AAFF0", Offset = "0x3AA1F0", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6001401")]
		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001402")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001400")]
		public override void Invoke(Result result) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007FA")]
	private IntPtr MethodsPtr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007FB")]
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007FC")]
	private EntitlementCreateHandler OnEntitlementCreate; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007FD")]
	private EntitlementDeleteHandler OnEntitlementDelete; //Field offset: 0x28

	[Token(Token = "0x14000013")]
	public event EntitlementCreateHandler OnEntitlementCreate
	{
		[Address(RVA = "0x3ADB20", Offset = "0x3ACD20", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60013A4")]
		 add { } //Length: 158
		[Address(RVA = "0x3ADD90", Offset = "0x3ACF90", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60013A5")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000014")]
	public event EntitlementDeleteHandler OnEntitlementDelete
	{
		[Address(RVA = "0x3ADBC0", Offset = "0x3ACDC0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60013A6")]
		 add { } //Length: 158
		[Address(RVA = "0x3ADE30", Offset = "0x3AD030", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60013A7")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x170001EA")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x3ADC60", Offset = "0x3ACE60", Length = "0x124")]
		[CalledBy(Type = typeof(StoreManager), Member = "StartPurchase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(StartPurchaseHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StoreManager), Member = "GetSkus", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Discord.Sku>))]
		[CalledBy(Type = typeof(StoreManager), Member = "GetEntitlements", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Discord.Entitlement>))]
		[CalledBy(Type = typeof(StoreManager), Member = "HasSkuEntitlement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(StoreManager), Member = "GetEntitlementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Entitlement))]
		[CalledBy(Type = typeof(StoreManager), Member = "CountEntitlements", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(StoreManager), Member = "GetEntitlement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Entitlement))]
		[CalledBy(Type = typeof(StoreManager), Member = "GetSkuAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Sku))]
		[CalledBy(Type = typeof(StoreManager), Member = "GetSku", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Sku))]
		[CalledBy(Type = typeof(StoreManager), Member = "CountSkus", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(StoreManager), Member = "FetchSkus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FetchSkusHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StoreManager), Member = "FetchEntitlements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FetchEntitlementsHandler)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x60013A3")]
		private get { } //Length: 292
	}

	[Address(RVA = "0x3ADA40", Offset = "0x3ACC40", Length = "0xD8")]
	[CalledBy(Type = typeof(Discord), Member = "GetStoreManager", ReturnType = typeof(StoreManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StoreManager), Member = "InitEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013A8")]
	internal StoreManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[Address(RVA = "0x3ADB20", Offset = "0x3ACD20", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60013A4")]
	public void add_OnEntitlementCreate(EntitlementCreateHandler value) { }

	[Address(RVA = "0x3ADBC0", Offset = "0x3ACDC0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60013A6")]
	public void add_OnEntitlementDelete(EntitlementDeleteHandler value) { }

	[Address(RVA = "0x3AC550", Offset = "0x3AB750", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StoreManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013B1")]
	public int CountEntitlements() { }

	[Address(RVA = "0x3AC5B0", Offset = "0x3AB7B0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StoreManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013AC")]
	public int CountSkus() { }

	[Address(RVA = "0x3AC710", Offset = "0x3AB910", Length = "0x15B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StoreManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013B0")]
	public void FetchEntitlements(FetchEntitlementsHandler callback) { }

	[Address(RVA = "0x3AC610", Offset = "0x3AB810", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x60013AF")]
	private static void FetchEntitlementsCallbackImpl(IntPtr ptr, Result result) { }

	[Address(RVA = "0x3AC970", Offset = "0x3ABB70", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StoreManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013AB")]
	public void FetchSkus(FetchSkusHandler callback) { }

	[Address(RVA = "0x3AC870", Offset = "0x3ABA70", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x60013AA")]
	private static void FetchSkusCallbackImpl(IntPtr ptr, Result result) { }

	[Address(RVA = "0x3ADC60", Offset = "0x3ACE60", Length = "0x124")]
	[CalledBy(Type = typeof(StoreManager), Member = "FetchEntitlements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FetchEntitlementsHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StoreManager), Member = "CountSkus", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StoreManager), Member = "GetSku", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Sku))]
	[CalledBy(Type = typeof(StoreManager), Member = "GetSkuAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Sku))]
	[CalledBy(Type = typeof(StoreManager), Member = "GetEntitlement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Entitlement))]
	[CalledBy(Type = typeof(StoreManager), Member = "FetchSkus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FetchSkusHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StoreManager), Member = "GetEntitlementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Entitlement))]
	[CalledBy(Type = typeof(StoreManager), Member = "HasSkuEntitlement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StoreManager), Member = "GetEntitlements", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Discord.Entitlement>))]
	[CalledBy(Type = typeof(StoreManager), Member = "GetSkus", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Discord.Sku>))]
	[CalledBy(Type = typeof(StoreManager), Member = "StartPurchase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(StartPurchaseHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StoreManager), Member = "CountEntitlements", ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013A3")]
	private FFIMethods get_Methods() { }

	[Address(RVA = "0x3ACB90", Offset = "0x3ABD90", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StoreManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013B2")]
	public Entitlement GetEntitlement(long entitlementId) { }

	[Address(RVA = "0x3ACAD0", Offset = "0x3ABCD0", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StoreManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013B3")]
	public Entitlement GetEntitlementAt(int index) { }

	[Address(RVA = "0x3ACC50", Offset = "0x3ABE50", Length = "0x22E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StoreManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60013B9")]
	public IEnumerable<Entitlement> GetEntitlements() { }

	[Address(RVA = "0x3ACF50", Offset = "0x3AC150", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StoreManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013AD")]
	public Sku GetSku(long skuId) { }

	[Address(RVA = "0x3ACE80", Offset = "0x3AC080", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StoreManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013AE")]
	public Sku GetSkuAt(int index) { }

	[Address(RVA = "0x3AD020", Offset = "0x3AC220", Length = "0x299")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StoreManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<Discord.Sku>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sku)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60013BA")]
	public IEnumerable<Sku> GetSkus() { }

	[Address(RVA = "0x3AD2C0", Offset = "0x3AC4C0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StoreManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013B4")]
	public bool HasSkuEntitlement(long skuId) { }

	[Address(RVA = "0x3AD380", Offset = "0x3AC580", Length = "0x20F")]
	[CalledBy(Type = typeof(StoreManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013A9")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[Address(RVA = "0x3AD590", Offset = "0x3AC790", Length = "0x11C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x60013B7")]
	private static void OnEntitlementCreateImpl(IntPtr ptr, ref Entitlement entitlement) { }

	[Address(RVA = "0x3AD6B0", Offset = "0x3AC8B0", Length = "0x11C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x60013B8")]
	private static void OnEntitlementDeleteImpl(IntPtr ptr, ref Entitlement entitlement) { }

	[Address(RVA = "0x3ADD90", Offset = "0x3ACF90", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60013A5")]
	public void remove_OnEntitlementCreate(EntitlementCreateHandler value) { }

	[Address(RVA = "0x3ADE30", Offset = "0x3AD030", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60013A7")]
	public void remove_OnEntitlementDelete(EntitlementDeleteHandler value) { }

	[Address(RVA = "0x3AD8D0", Offset = "0x3ACAD0", Length = "0x16A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StoreManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013B6")]
	public void StartPurchase(long skuId, StartPurchaseHandler callback) { }

	[Address(RVA = "0x3AD7D0", Offset = "0x3AC9D0", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x60013B5")]
	private static void StartPurchaseCallbackImpl(IntPtr ptr, Result result) { }

}

