namespace Polytoria.Datamodel.Proxies.Services;

[Token(Token = "0x20003D2")]
public class AchievementServiceProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400101C")]
	private readonly AchievementService achievementService; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x600298B")]
	public AchievementServiceProxy(AchievementService target) { }

	[Address(RVA = "0x49EBB0", Offset = "0x49DDB0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementService), Member = "Award", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[LuaCallbackParameter("callback", typeof(bool), "success", False)]
	[LuaCallbackParameter("callback", typeof(string), "error", True)]
	[Token(Token = "0x600298C")]
	public void Award(int userID, int achievementID, DynValue callback) { }

	[Address(RVA = "0x49EBE0", Offset = "0x49DDE0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementService), Member = "HasAchievement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[LuaCallbackParameter("callback", typeof(bool), "owned", False)]
	[LuaCallbackParameter("callback", typeof(bool), "success", False)]
	[LuaCallbackParameter("callback", typeof(string), "error", True)]
	[Token(Token = "0x600298D")]
	public void HasAchievement(int userID, int achievementID, DynValue callback) { }

}

