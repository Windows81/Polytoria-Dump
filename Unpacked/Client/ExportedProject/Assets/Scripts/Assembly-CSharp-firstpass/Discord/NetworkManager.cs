namespace Discord;

[Token(Token = "0x2000285")]
public class NetworkManager
{
	[Token(Token = "0x2000286")]
	public struct FFIEvents
	{
		[Token(Token = "0x2000287")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class MessageHandler : MulticastDelegate
		{

			[Address(RVA = "0x3A63D0", Offset = "0x3A55D0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x600127A")]
			public MessageHandler(object object, IntPtr method) { }

			[Address(RVA = "0x3A6290", Offset = "0x3A5490", Length = "0xB7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x600127C")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x600127D")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600127B")]
			public override void Invoke(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen) { }

		}

		[Token(Token = "0x2000288")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class RouteUpdateHandler : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600127E")]
			public RouteUpdateHandler(object object, IntPtr method) { }

			[Address(RVA = "0x38E2C0", Offset = "0x38D4C0", Length = "0x66")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001280")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, string routeData, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001281")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600127F")]
			public override void Invoke(IntPtr ptr, string routeData) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007CC")]
		internal MessageHandler OnMessage; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007CD")]
		internal RouteUpdateHandler OnRouteUpdate; //Field offset: 0x8

	}

	[Token(Token = "0x2000289")]
	public struct FFIMethods
	{
		[Token(Token = "0x2000290")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class CloseChannelMethod : MulticastDelegate
		{

			[Address(RVA = "0x3A4C80", Offset = "0x3A3E80", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600129A")]
			public CloseChannelMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A4C00", Offset = "0x3A3E00", Length = "0x7F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x600129C")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, byte channelId, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x600129D")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600129B")]
			public override Result Invoke(IntPtr methodsPtr, ulong peerId, byte channelId) { }

		}

		[Token(Token = "0x200028E")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ClosePeerMethod : MulticastDelegate
		{

			[Address(RVA = "0x391980", Offset = "0x390B80", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001292")]
			public ClosePeerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A4D30", Offset = "0x3A3F30", Length = "0x6F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001294")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001295")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001293")]
			public override Result Invoke(IntPtr methodsPtr, ulong peerId) { }

		}

		[Token(Token = "0x200028B")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FlushMethod : MulticastDelegate
		{

			[Address(RVA = "0x395EA0", Offset = "0x3950A0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001286")]
			public FlushMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001288")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001289")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001287")]
			public override Result Invoke(IntPtr methodsPtr) { }

		}

		[Token(Token = "0x200028A")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetPeerIdMethod : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001282")]
			public GetPeerIdMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A57B0", Offset = "0x3A49B0", Length = "0x75")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001284")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref ulong peerId, AsyncCallback callback, object object) { }

			[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001285")]
			public override void EndInvoke(ref ulong peerId, IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001283")]
			public override void Invoke(IntPtr methodsPtr, ref ulong peerId) { }

		}

		[Token(Token = "0x200028F")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class OpenChannelMethod : MulticastDelegate
		{

			[Address(RVA = "0x39FF10", Offset = "0x39F110", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001296")]
			public OpenChannelMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A79A0", Offset = "0x3A6BA0", Length = "0x9E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001298")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001299")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x39FEF0", Offset = "0x39F0F0", Length = "0x1D")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001297")]
			public override Result Invoke(IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable) { }

		}

		[Token(Token = "0x200028C")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class OpenPeerMethod : MulticastDelegate
		{

			[Address(RVA = "0x397000", Offset = "0x396200", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600128A")]
			public OpenPeerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A7B50", Offset = "0x3A6D50", Length = "0x76")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600128C")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, string routeData, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x600128D")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600128B")]
			public override Result Invoke(IntPtr methodsPtr, ulong peerId, string routeData) { }

		}

		[Token(Token = "0x2000291")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SendMessageMethod : MulticastDelegate
		{

			[Address(RVA = "0x3A9EC0", Offset = "0x3A90C0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x600129E")]
			public SendMessageMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A9E10", Offset = "0x3A9010", Length = "0xAB")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60012A0")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, byte channelId, Byte[] data, int dataLen, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012A1")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600129F")]
			public override Result Invoke(IntPtr methodsPtr, ulong peerId, byte channelId, Byte[] data, int dataLen) { }

		}

		[Token(Token = "0x200028D")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class UpdatePeerMethod : MulticastDelegate
		{

			[Address(RVA = "0x397000", Offset = "0x396200", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600128E")]
			public UpdatePeerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A7B50", Offset = "0x3A6D50", Length = "0x76")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001290")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, string routeData, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001291")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600128F")]
			public override Result Invoke(IntPtr methodsPtr, ulong peerId, string routeData) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007CE")]
		internal GetPeerIdMethod GetPeerId; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007CF")]
		internal FlushMethod Flush; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007D0")]
		internal OpenPeerMethod OpenPeer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007D1")]
		internal UpdatePeerMethod UpdatePeer; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007D2")]
		internal ClosePeerMethod ClosePeer; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007D3")]
		internal OpenChannelMethod OpenChannel; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40007D4")]
		internal CloseChannelMethod CloseChannel; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40007D5")]
		internal SendMessageMethod SendMessage; //Field offset: 0x38

	}

	[Token(Token = "0x2000292")]
	internal sealed class MessageHandler : MulticastDelegate
	{

		[Address(RVA = "0x3A6480", Offset = "0x3A5680", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60012A2")]
		public MessageHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3A6350", Offset = "0x3A5550", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x60012A4")]
		public override IAsyncResult BeginInvoke(ulong peerId, byte channelId, Byte[] data, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x60012A5")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012A3")]
		public override void Invoke(ulong peerId, byte channelId, Byte[] data) { }

	}

	[Token(Token = "0x2000293")]
	internal sealed class RouteUpdateHandler : MulticastDelegate
	{

		[Address(RVA = "0x38E330", Offset = "0x38D530", Length = "0xB4")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60012A6")]
		public RouteUpdateHandler(object object, IntPtr method) { }

		[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60012A8")]
		public override IAsyncResult BeginInvoke(string routeData, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x60012A9")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012A7")]
		public override void Invoke(string routeData) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007C8")]
	private IntPtr MethodsPtr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007C9")]
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007CA")]
	private MessageHandler OnMessage; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007CB")]
	private RouteUpdateHandler OnRouteUpdate; //Field offset: 0x28

	[Token(Token = "0x14000010")]
	public event MessageHandler OnMessage
	{
		[Address(RVA = "0x3A72F0", Offset = "0x3A64F0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600126A")]
		 add { } //Length: 158
		[Address(RVA = "0x3A7550", Offset = "0x3A6750", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600126B")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000011")]
	public event RouteUpdateHandler OnRouteUpdate
	{
		[Address(RVA = "0x3A7390", Offset = "0x3A6590", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600126C")]
		 add { } //Length: 158
		[Address(RVA = "0x3A75F0", Offset = "0x3A67F0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600126D")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x170001E7")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x3A7430", Offset = "0x3A6630", Length = "0x11C")]
		[CalledBy(Type = typeof(NetworkManager), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(byte), typeof(Byte[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkManager), Member = "GetPeerId", ReturnType = typeof(ulong))]
		[CalledBy(Type = typeof(NetworkManager), Member = "Flush", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkManager), Member = "OpenPeer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkManager), Member = "UpdatePeer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkManager), Member = "ClosePeer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkManager), Member = "OpenChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkManager), Member = "CloseChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(byte)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x6001269")]
		private get { } //Length: 284
	}

	[Address(RVA = "0x3A7210", Offset = "0x3A6410", Length = "0xD8")]
	[CalledBy(Type = typeof(Discord), Member = "GetNetworkManager", ReturnType = typeof(NetworkManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkManager), Member = "InitEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600126E")]
	internal NetworkManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[Address(RVA = "0x3A72F0", Offset = "0x3A64F0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600126A")]
	public void add_OnMessage(MessageHandler value) { }

	[Address(RVA = "0x3A7390", Offset = "0x3A6590", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600126C")]
	public void add_OnRouteUpdate(RouteUpdateHandler value) { }

	[Address(RVA = "0x3A6790", Offset = "0x3A5990", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001276")]
	public void CloseChannel(ulong peerId, byte channelId) { }

	[Address(RVA = "0x3A6850", Offset = "0x3A5A50", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001274")]
	public void ClosePeer(ulong peerId) { }

	[Address(RVA = "0x3A68F0", Offset = "0x3A5AF0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001271")]
	public void Flush() { }

	[Address(RVA = "0x3A7430", Offset = "0x3A6630", Length = "0x11C")]
	[CalledBy(Type = typeof(NetworkManager), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(byte), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "GetPeerId", ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(NetworkManager), Member = "Flush", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "OpenPeer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "UpdatePeer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "ClosePeer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "OpenChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "CloseChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x6001269")]
	private FFIMethods get_Methods() { }

	[Address(RVA = "0x3A6990", Offset = "0x3A5B90", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001270")]
	public ulong GetPeerId() { }

	[Address(RVA = "0x3A6A00", Offset = "0x3A5C00", Length = "0x20F")]
	[CalledBy(Type = typeof(NetworkManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600126F")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[Address(RVA = "0x3A6C10", Offset = "0x3A5E10", Length = "0x1CD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x6001278")]
	private static void OnMessageImpl(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen) { }

	[Address(RVA = "0x3A6DE0", Offset = "0x3A5FE0", Length = "0x11C")]
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
	[Token(Token = "0x6001279")]
	private static void OnRouteUpdateImpl(IntPtr ptr, string routeData) { }

	[Address(RVA = "0x3A6F00", Offset = "0x3A6100", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001275")]
	public void OpenChannel(ulong peerId, byte channelId, bool reliable) { }

	[Address(RVA = "0x3A6FD0", Offset = "0x3A61D0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001272")]
	public void OpenPeer(ulong peerId, string routeData) { }

	[Address(RVA = "0x3A7550", Offset = "0x3A6750", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600126B")]
	public void remove_OnMessage(MessageHandler value) { }

	[Address(RVA = "0x3A75F0", Offset = "0x3A67F0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600126D")]
	public void remove_OnRouteUpdate(RouteUpdateHandler value) { }

	[Address(RVA = "0x3A7080", Offset = "0x3A6280", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001277")]
	public void SendMessage(ulong peerId, byte channelId, Byte[] data) { }

	[Address(RVA = "0x3A7160", Offset = "0x3A6360", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001273")]
	public void UpdatePeer(ulong peerId, string routeData) { }

}

