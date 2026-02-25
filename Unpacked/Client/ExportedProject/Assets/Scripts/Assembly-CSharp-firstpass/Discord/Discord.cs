namespace Discord;

[Token(Token = "0x20001F7")]
public class Discord : IDisposable
{
	[Token(Token = "0x200020A")]
	public struct FFICreateParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400075B")]
		internal long ClientId; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400075C")]
		internal ulong Flags; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400075D")]
		internal IntPtr Events; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400075E")]
		internal IntPtr EventData; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400075F")]
		internal IntPtr ApplicationEvents; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000760")]
		internal uint ApplicationVersion; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000761")]
		internal IntPtr UserEvents; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000762")]
		internal uint UserVersion; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000763")]
		internal IntPtr ImageEvents; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000764")]
		internal uint ImageVersion; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000765")]
		internal IntPtr ActivityEvents; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000766")]
		internal uint ActivityVersion; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000767")]
		internal IntPtr RelationshipEvents; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000768")]
		internal uint RelationshipVersion; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000769")]
		internal IntPtr LobbyEvents; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400076A")]
		internal uint LobbyVersion; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400076B")]
		internal IntPtr NetworkEvents; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400076C")]
		internal uint NetworkVersion; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400076D")]
		internal IntPtr OverlayEvents; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400076E")]
		internal uint OverlayVersion; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400076F")]
		internal IntPtr StorageEvents; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000770")]
		internal uint StorageVersion; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000771")]
		internal IntPtr StoreEvents; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000772")]
		internal uint StoreVersion; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000773")]
		internal IntPtr VoiceEvents; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4000774")]
		internal uint VoiceVersion; //Field offset: 0xC8
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4000775")]
		internal IntPtr AchievementEvents; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4000776")]
		internal uint AchievementVersion; //Field offset: 0xD8

	}

	[Token(Token = "0x20001F8")]
	public struct FFIEvents
	{

	}

	[Token(Token = "0x20001F9")]
	public struct FFIMethods
	{
		[Token(Token = "0x20001FA")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class DestroyHandler : MulticastDelegate
		{

			[Address(RVA = "0x391F20", Offset = "0x391120", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001009")]
			public DestroyHandler(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600100B")]
			public override IAsyncResult BeginInvoke(IntPtr MethodsPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x600100C")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600100A")]
			public override void Invoke(IntPtr MethodsPtr) { }

		}

		[Token(Token = "0x2000209")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetAchievementManagerMethod : MulticastDelegate
		{

			[Address(RVA = "0x396970", Offset = "0x395B70", Length = "0xA6")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001045")]
			public GetAchievementManagerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001047")]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x396940", Offset = "0x395B40", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001048")]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001046")]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[Token(Token = "0x2000201")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetActivityManagerMethod : MulticastDelegate
		{

			[Address(RVA = "0x396970", Offset = "0x395B70", Length = "0xA6")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001025")]
			public GetActivityManagerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001027")]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x396940", Offset = "0x395B40", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001028")]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001026")]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[Token(Token = "0x20001FE")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetApplicationManagerMethod : MulticastDelegate
		{

			[Address(RVA = "0x396970", Offset = "0x395B70", Length = "0xA6")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001019")]
			public GetApplicationManagerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600101B")]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x396940", Offset = "0x395B40", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x600101C")]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600101A")]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[Token(Token = "0x2000200")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetImageManagerMethod : MulticastDelegate
		{

			[Address(RVA = "0x396970", Offset = "0x395B70", Length = "0xA6")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001021")]
			public GetImageManagerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001023")]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x396940", Offset = "0x395B40", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001024")]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001022")]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[Token(Token = "0x2000203")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetLobbyManagerMethod : MulticastDelegate
		{

			[Address(RVA = "0x396970", Offset = "0x395B70", Length = "0xA6")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600102D")]
			public GetLobbyManagerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600102F")]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x396940", Offset = "0x395B40", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001030")]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600102E")]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[Token(Token = "0x2000204")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetNetworkManagerMethod : MulticastDelegate
		{

			[Address(RVA = "0x396970", Offset = "0x395B70", Length = "0xA6")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001031")]
			public GetNetworkManagerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001033")]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x396940", Offset = "0x395B40", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001034")]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001032")]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[Token(Token = "0x2000205")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetOverlayManagerMethod : MulticastDelegate
		{

			[Address(RVA = "0x396970", Offset = "0x395B70", Length = "0xA6")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001035")]
			public GetOverlayManagerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001037")]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x396940", Offset = "0x395B40", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001038")]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001036")]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[Token(Token = "0x2000202")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetRelationshipManagerMethod : MulticastDelegate
		{

			[Address(RVA = "0x396970", Offset = "0x395B70", Length = "0xA6")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001029")]
			public GetRelationshipManagerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600102B")]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x396940", Offset = "0x395B40", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x600102C")]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600102A")]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[Token(Token = "0x2000206")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetStorageManagerMethod : MulticastDelegate
		{

			[Address(RVA = "0x396970", Offset = "0x395B70", Length = "0xA6")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001039")]
			public GetStorageManagerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600103B")]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x396940", Offset = "0x395B40", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x600103C")]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600103A")]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[Token(Token = "0x2000207")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetStoreManagerMethod : MulticastDelegate
		{

			[Address(RVA = "0x396970", Offset = "0x395B70", Length = "0xA6")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600103D")]
			public GetStoreManagerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600103F")]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x396940", Offset = "0x395B40", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001040")]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600103E")]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[Token(Token = "0x20001FF")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetUserManagerMethod : MulticastDelegate
		{

			[Address(RVA = "0x396970", Offset = "0x395B70", Length = "0xA6")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600101D")]
			public GetUserManagerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600101F")]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x396940", Offset = "0x395B40", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001020")]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600101E")]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[Token(Token = "0x2000208")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetVoiceManagerMethod : MulticastDelegate
		{

			[Address(RVA = "0x396970", Offset = "0x395B70", Length = "0xA6")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001041")]
			public GetVoiceManagerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001043")]
			public override IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x396940", Offset = "0x395B40", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001044")]
			public override IntPtr EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001042")]
			public override IntPtr Invoke(IntPtr discordPtr) { }

		}

		[Token(Token = "0x20001FB")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class RunCallbacksMethod : MulticastDelegate
		{

			[Address(RVA = "0x395EA0", Offset = "0x3950A0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600100D")]
			public RunCallbacksMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600100F")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001010")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600100E")]
			public override Result Invoke(IntPtr methodsPtr) { }

		}

		[Token(Token = "0x20001FC")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetLogHookCallback : MulticastDelegate
		{

			[Address(RVA = "0x3913A0", Offset = "0x3905A0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001011")]
			public SetLogHookCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3A19A0", Offset = "0x3A0BA0", Length = "0x92")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001013")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, LogLevel level, string message, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001014")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001012")]
			public override void Invoke(IntPtr ptr, LogLevel level, string message) { }

		}

		[Token(Token = "0x20001FD")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetLogHookMethod : MulticastDelegate
		{

			[Address(RVA = "0x38E160", Offset = "0x38D360", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001015")]
			public SetLogHookMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A1AD0", Offset = "0x3A0CD0", Length = "0xAE")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001017")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, SetLogHookCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001018")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001016")]
			public override void Invoke(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, SetLogHookCallback callback) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400074C")]
		internal DestroyHandler Destroy; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400074D")]
		internal RunCallbacksMethod RunCallbacks; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400074E")]
		internal SetLogHookMethod SetLogHook; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400074F")]
		internal GetApplicationManagerMethod GetApplicationManager; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000750")]
		internal GetUserManagerMethod GetUserManager; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000751")]
		internal GetImageManagerMethod GetImageManager; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000752")]
		internal GetActivityManagerMethod GetActivityManager; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000753")]
		internal GetRelationshipManagerMethod GetRelationshipManager; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000754")]
		internal GetLobbyManagerMethod GetLobbyManager; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000755")]
		internal GetNetworkManagerMethod GetNetworkManager; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000756")]
		internal GetOverlayManagerMethod GetOverlayManager; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000757")]
		internal GetStorageManagerMethod GetStorageManager; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000758")]
		internal GetStoreManagerMethod GetStoreManager; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000759")]
		internal GetVoiceManagerMethod GetVoiceManager; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400075A")]
		internal GetAchievementManagerMethod GetAchievementManager; //Field offset: 0x70

	}

	[Token(Token = "0x200020B")]
	internal sealed class SetLogHookHandler : MulticastDelegate
	{

		[Address(RVA = "0x3914F0", Offset = "0x3906F0", Length = "0xA6")]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001049")]
		public SetLogHookHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3A1A40", Offset = "0x3A0C40", Length = "0x81")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x600104B")]
		public override IAsyncResult BeginInvoke(LogLevel level, string message, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x600104C")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600104A")]
		public override void Invoke(LogLevel level, string message) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000722")]
	private GCHandle SelfHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000723")]
	private IntPtr EventsPtr; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000724")]
	private FFIEvents Events; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000725")]
	private IntPtr ApplicationEventsPtr; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000726")]
	private FFIEvents ApplicationEvents; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000727")]
	internal ApplicationManager ApplicationManagerInstance; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000728")]
	private IntPtr UserEventsPtr; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000729")]
	private FFIEvents UserEvents; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400072A")]
	internal UserManager UserManagerInstance; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400072B")]
	private IntPtr ImageEventsPtr; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400072C")]
	private FFIEvents ImageEvents; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400072D")]
	internal ImageManager ImageManagerInstance; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400072E")]
	private IntPtr ActivityEventsPtr; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400072F")]
	private FFIEvents ActivityEvents; //Field offset: 0x78
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000730")]
	internal ActivityManager ActivityManagerInstance; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000731")]
	private IntPtr RelationshipEventsPtr; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000732")]
	private FFIEvents RelationshipEvents; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000733")]
	internal RelationshipManager RelationshipManagerInstance; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000734")]
	private IntPtr LobbyEventsPtr; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000735")]
	private FFIEvents LobbyEvents; //Field offset: 0xC8
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000736")]
	internal LobbyManager LobbyManagerInstance; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000737")]
	private IntPtr NetworkEventsPtr; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000738")]
	private FFIEvents NetworkEvents; //Field offset: 0x118
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000739")]
	internal NetworkManager NetworkManagerInstance; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400073A")]
	private IntPtr OverlayEventsPtr; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400073B")]
	private FFIEvents OverlayEvents; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400073C")]
	internal OverlayManager OverlayManagerInstance; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400073D")]
	private IntPtr StorageEventsPtr; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400073E")]
	private FFIEvents StorageEvents; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x400073F")]
	internal StorageManager StorageManagerInstance; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000740")]
	private IntPtr StoreEventsPtr; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000741")]
	private FFIEvents StoreEvents; //Field offset: 0x168
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000742")]
	internal StoreManager StoreManagerInstance; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000743")]
	private IntPtr VoiceEventsPtr; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000744")]
	private FFIEvents VoiceEvents; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000745")]
	internal VoiceManager VoiceManagerInstance; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000746")]
	private IntPtr AchievementEventsPtr; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000747")]
	private FFIEvents AchievementEvents; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000748")]
	internal AchievementManager AchievementManagerInstance; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000749")]
	private IntPtr MethodsPtr; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x400074A")]
	private object MethodsStructure; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400074B")]
	private Nullable<GCHandle> setLogHook; //Field offset: 0x1C0

	[Token(Token = "0x170001E1")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x393F60", Offset = "0x393160", Length = "0x14D")]
		[CalledBy(Type = typeof(Discord), Member = "GetOverlayManager", ReturnType = typeof(OverlayManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetAchievementManager", ReturnType = typeof(AchievementManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetVoiceManager", ReturnType = typeof(VoiceManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetStoreManager", ReturnType = typeof(StoreManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetStorageManager", ReturnType = typeof(StorageManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetNetworkManager", ReturnType = typeof(NetworkManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetLobbyManager", ReturnType = typeof(LobbyManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetRelationshipManager", ReturnType = typeof(RelationshipManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetImageManager", ReturnType = typeof(ImageManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetUserManager", ReturnType = typeof(UserManager))]
		[CalledBy(Type = typeof(Discord), Member = "GetApplicationManager", ReturnType = typeof(ApplicationManager))]
		[CalledBy(Type = typeof(Discord), Member = "SetLogHook", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogLevel), typeof(SetLogHookHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Discord), Member = "RunCallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Discord), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Discord), Member = "GetActivityManager", ReturnType = typeof(ActivityManager))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x6000FF6")]
		private get { } //Length: 333
	}

	[Address(RVA = "0x3939F0", Offset = "0x392BF0", Length = "0x56C")]
	[CalledBy(Type = "Polytoria.Controllers.DiscordController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FFIEvents)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FFIEvents)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Discord), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FFIEvents)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FFIEvents)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FF7")]
	public Discord(long clientId, ulong flags) { }

	[Address(RVA = "0x392280", Offset = "0x391480", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FF5")]
	private static Result DiscordCreate(uint version, ref FFICreateParams createParams, out IntPtr manager) { }

	[Address(RVA = "0x392320", Offset = "0x391520", Length = "0x199")]
	[CalledBy(Type = "Polytoria.Controllers.DiscordController", Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Discord), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ulong)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FF9")]
	public override void Dispose() { }

	[Address(RVA = "0x393F60", Offset = "0x393160", Length = "0x14D")]
	[CalledBy(Type = typeof(Discord), Member = "GetActivityManager", ReturnType = typeof(ActivityManager))]
	[CalledBy(Type = typeof(Discord), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Discord), Member = "RunCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Discord), Member = "GetApplicationManager", ReturnType = typeof(ApplicationManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetUserManager", ReturnType = typeof(UserManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetImageManager", ReturnType = typeof(ImageManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetRelationshipManager", ReturnType = typeof(RelationshipManager))]
	[CalledBy(Type = typeof(Discord), Member = "SetLogHook", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogLevel), typeof(SetLogHookHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Discord), Member = "GetNetworkManager", ReturnType = typeof(NetworkManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetStorageManager", ReturnType = typeof(StorageManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetStoreManager", ReturnType = typeof(StoreManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetVoiceManager", ReturnType = typeof(VoiceManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetAchievementManager", ReturnType = typeof(AchievementManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetOverlayManager", ReturnType = typeof(OverlayManager))]
	[CalledBy(Type = typeof(Discord), Member = "GetLobbyManager", ReturnType = typeof(LobbyManager))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000FF6")]
	private FFIMethods get_Methods() { }

	[Address(RVA = "0x3924C0", Offset = "0x3916C0", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AchievementManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001008")]
	public AchievementManager GetAchievementManager() { }

	[Address(RVA = "0x3925D0", Offset = "0x3917D0", Length = "0x188")]
	[CalledBy(Type = "Polytoria.Controllers.DiscordController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ActivityManager), Member = "InitEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001000")]
	public ActivityManager GetActivityManager() { }

	[Address(RVA = "0x392760", Offset = "0x391960", Length = "0x1C1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FFD")]
	public ApplicationManager GetApplicationManager() { }

	[Address(RVA = "0x392930", Offset = "0x391B30", Length = "0x1C1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FFF")]
	public ImageManager GetImageManager() { }

	[Address(RVA = "0x392B00", Offset = "0x391D00", Length = "0x18E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LobbyManager), Member = "InitEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001002")]
	public LobbyManager GetLobbyManager() { }

	[Address(RVA = "0x392C90", Offset = "0x391E90", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001003")]
	public NetworkManager GetNetworkManager() { }

	[Address(RVA = "0x392D90", Offset = "0x391F90", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverlayManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001004")]
	public OverlayManager GetOverlayManager() { }

	[Address(RVA = "0x392E90", Offset = "0x392090", Length = "0x18E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RelationshipManager), Member = "InitEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001001")]
	public RelationshipManager GetRelationshipManager() { }

	[Address(RVA = "0x393020", Offset = "0x392220", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StorageManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001005")]
	public StorageManager GetStorageManager() { }

	[Address(RVA = "0x393120", Offset = "0x392320", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StoreManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001006")]
	public StoreManager GetStoreManager() { }

	[Address(RVA = "0x393220", Offset = "0x392420", Length = "0x2B9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FFE")]
	public UserManager GetUserManager() { }

	[Address(RVA = "0x3934E0", Offset = "0x3926E0", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VoiceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(FFIEvents&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001007")]
	public VoiceManager GetVoiceManager() { }

	[Address(RVA = "0x3935E0", Offset = "0x3927E0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000FF8")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[Address(RVA = "0x393650", Offset = "0x392850", Length = "0x9D")]
	[CalledBy(Type = "Polytoria.Controllers.DiscordController", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FFA")]
	public void RunCallbacks() { }

	[Address(RVA = "0x3937F0", Offset = "0x3929F0", Length = "0x1F7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Discord), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FFC")]
	public void SetLogHook(LogLevel minLevel, SetLogHookHandler callback) { }

	[Address(RVA = "0x3936F0", Offset = "0x3928F0", Length = "0xFD")]
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
	[Token(Token = "0x6000FFB")]
	private static void SetLogHookCallbackImpl(IntPtr ptr, LogLevel level, string message) { }

}

