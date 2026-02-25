namespace Discord;

[Token(Token = "0x20002F4")]
public class AchievementManager
{
	[Token(Token = "0x2000300")]
	internal sealed class FetchUserAchievementsHandler : MulticastDelegate
	{

		[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001485")]
		public FetchUserAchievementsHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3A5430", Offset = "0x3A4630", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6001487")]
		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001488")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001486")]
		public override void Invoke(Result result) { }

	}

	[Token(Token = "0x20002F5")]
	public struct FFIEvents
	{
		[Token(Token = "0x20002F6")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class UserAchievementUpdateHandler : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001461")]
			public UserAchievementUpdateHandler(object object, IntPtr method) { }

			[Address(RVA = "0x3AE180", Offset = "0x3AD380", Length = "0x91")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001463")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

			[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001464")]
			public override void EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001462")]
			public override void Invoke(IntPtr ptr, ref UserAchievement userAchievement) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400081B")]
		internal UserAchievementUpdateHandler OnUserAchievementUpdate; //Field offset: 0x0

	}

	[Token(Token = "0x20002F7")]
	public struct FFIMethods
	{
		[Token(Token = "0x20002FC")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class CountUserAchievementsMethod : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001475")]
			public CountUserAchievementsMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391AC0", Offset = "0x390CC0", Length = "0x75")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001477")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

			[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001478")]
			public override void EndInvoke(ref int count, IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001476")]
			public override void Invoke(IntPtr methodsPtr, ref int count) { }

		}

		[Token(Token = "0x20002FA")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FetchUserAchievementsCallback : MulticastDelegate
		{

			[Address(RVA = "0x38DC70", Offset = "0x38CE70", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600146D")]
			public FetchUserAchievementsCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3A53A0", Offset = "0x3A45A0", Length = "0x8B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x600146F")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001470")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600146E")]
			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[Token(Token = "0x20002FB")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FetchUserAchievementsMethod : MulticastDelegate
		{

			[Address(RVA = "0x391240", Offset = "0x390440", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001471")]
			public FetchUserAchievementsMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3911C0", Offset = "0x3903C0", Length = "0x76")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001473")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, FetchUserAchievementsCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001474")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001472")]
			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, FetchUserAchievementsCallback callback) { }

		}

		[Token(Token = "0x20002FE")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetUserAchievementAtMethod : MulticastDelegate
		{

			[Address(RVA = "0x391E10", Offset = "0x391010", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600147D")]
			public GetUserAchievementAtMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A5990", Offset = "0x3A4B90", Length = "0xA1")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x600147F")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391B40", Offset = "0x390D40", Length = "0x2F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001480")]
			public override Result EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600147E")]
			public override Result Invoke(IntPtr methodsPtr, int index, ref UserAchievement userAchievement) { }

		}

		[Token(Token = "0x20002FD")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetUserAchievementMethod : MulticastDelegate
		{

			[Address(RVA = "0x397000", Offset = "0x396200", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001479")]
			public GetUserAchievementMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A5A40", Offset = "0x3A4C40", Length = "0xA1")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x600147B")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391B40", Offset = "0x390D40", Length = "0x2F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x600147C")]
			public override Result EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600147A")]
			public override Result Invoke(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement) { }

		}

		[Token(Token = "0x20002F8")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetUserAchievementCallback : MulticastDelegate
		{

			[Address(RVA = "0x38DC70", Offset = "0x38CE70", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001465")]
			public SetUserAchievementCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3AABC0", Offset = "0x3A9DC0", Length = "0x8B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001467")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001468")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001466")]
			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[Token(Token = "0x20002F9")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetUserAchievementMethod : MulticastDelegate
		{

			[Address(RVA = "0x3AAD80", Offset = "0x3A9F80", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6001469")]
			public SetUserAchievementMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3AACD0", Offset = "0x3A9ED0", Length = "0xAB")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x600146B")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, SetUserAchievementCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x600146C")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600146A")]
			public override void Invoke(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, SetUserAchievementCallback callback) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400081C")]
		internal SetUserAchievementMethod SetUserAchievement; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400081D")]
		internal FetchUserAchievementsMethod FetchUserAchievements; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400081E")]
		internal CountUserAchievementsMethod CountUserAchievements; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400081F")]
		internal GetUserAchievementMethod GetUserAchievement; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000820")]
		internal GetUserAchievementAtMethod GetUserAchievementAt; //Field offset: 0x20

	}

	[Token(Token = "0x20002FF")]
	internal sealed class SetUserAchievementHandler : MulticastDelegate
	{

		[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001481")]
		public SetUserAchievementHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3AAC50", Offset = "0x3A9E50", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6001483")]
		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001484")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001482")]
		public override void Invoke(Result result) { }

	}

	[Token(Token = "0x2000301")]
	internal sealed class UserAchievementUpdateHandler : MulticastDelegate
	{

		[Address(RVA = "0x38E5F0", Offset = "0x38D7F0", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001489")]
		public UserAchievementUpdateHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3AE0F0", Offset = "0x3AD2F0", Length = "0x81")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x600148B")]
		public override IAsyncResult BeginInvoke(ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

		[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x600148C")]
		public override void EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600148A")]
		public override void Invoke(ref UserAchievement userAchievement) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000818")]
	private IntPtr MethodsPtr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000819")]
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400081A")]
	private UserAchievementUpdateHandler OnUserAchievementUpdate; //Field offset: 0x20

	[Token(Token = "0x14000016")]
	public event UserAchievementUpdateHandler OnUserAchievementUpdate
	{
		[Address(RVA = "0x3A49A0", Offset = "0x3A3BA0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001455")]
		 add { } //Length: 158
		[Address(RVA = "0x3A4B60", Offset = "0x3A3D60", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001456")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x170001EC")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x3A4A40", Offset = "0x3A3C40", Length = "0x116")]
		[CalledBy(Type = typeof(AchievementManager), Member = "SetUserAchievement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(byte), typeof(SetUserAchievementHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AchievementManager), Member = "FetchUserAchievements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FetchUserAchievementsHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AchievementManager), Member = "CountUserAchievements", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(AchievementManager), Member = "GetUserAchievement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(UserAchievement))]
		[CalledBy(Type = typeof(AchievementManager), Member = "GetUserAchievementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UserAchievement))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6001454")]
		private get { } //Length: 278
	}

	[Address(RVA = "0x3A47B0", Offset = "0x3A39B0", Length = "0x1E9")]
	[CalledBy(Type = typeof(Discord), Member = "GetAchievementManager", ReturnType = typeof(AchievementManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001457")]
	internal AchievementManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[Address(RVA = "0x3A49A0", Offset = "0x3A3BA0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001455")]
	public void add_OnUserAchievementUpdate(UserAchievementUpdateHandler value) { }

	[Address(RVA = "0x3A3E60", Offset = "0x3A3060", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600145D")]
	public int CountUserAchievements() { }

	[Address(RVA = "0x3A3FC0", Offset = "0x3A31C0", Length = "0x161")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(AchievementManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600145C")]
	public void FetchUserAchievements(FetchUserAchievementsHandler callback) { }

	[Address(RVA = "0x3A3EC0", Offset = "0x3A30C0", Length = "0xFF")]
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
	[Token(Token = "0x600145B")]
	private static void FetchUserAchievementsCallbackImpl(IntPtr ptr, Result result) { }

	[Address(RVA = "0x3A4A40", Offset = "0x3A3C40", Length = "0x116")]
	[CalledBy(Type = typeof(AchievementManager), Member = "SetUserAchievement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(byte), typeof(SetUserAchievementHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AchievementManager), Member = "FetchUserAchievements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FetchUserAchievementsHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AchievementManager), Member = "CountUserAchievements", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AchievementManager), Member = "GetUserAchievement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(UserAchievement))]
	[CalledBy(Type = typeof(AchievementManager), Member = "GetUserAchievementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UserAchievement))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001454")]
	private FFIMethods get_Methods() { }

	[Address(RVA = "0x3A4200", Offset = "0x3A3400", Length = "0xB8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600145E")]
	public UserAchievement GetUserAchievement(long userAchievementId) { }

	[Address(RVA = "0x3A4130", Offset = "0x3A3330", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600145F")]
	public UserAchievement GetUserAchievementAt(int index) { }

	[Address(RVA = "0x3A42C0", Offset = "0x3A34C0", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001458")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[Address(RVA = "0x3A4410", Offset = "0x3A3610", Length = "0x11C")]
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
	[Token(Token = "0x6001460")]
	private static void OnUserAchievementUpdateImpl(IntPtr ptr, ref UserAchievement userAchievement) { }

	[Address(RVA = "0x3A4B60", Offset = "0x3A3D60", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001456")]
	public void remove_OnUserAchievementUpdate(UserAchievementUpdateHandler value) { }

	[Address(RVA = "0x3A4630", Offset = "0x3A3830", Length = "0x172")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(AchievementManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600145A")]
	public void SetUserAchievement(long achievementId, byte percentComplete, SetUserAchievementHandler callback) { }

	[Address(RVA = "0x3A4530", Offset = "0x3A3730", Length = "0xFF")]
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
	[Token(Token = "0x6001459")]
	private static void SetUserAchievementCallbackImpl(IntPtr ptr, Result result) { }

}

