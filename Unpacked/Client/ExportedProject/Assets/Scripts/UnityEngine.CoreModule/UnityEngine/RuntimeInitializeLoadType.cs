namespace UnityEngine;

[Token(Token = "0x2000155")]
public enum RuntimeInitializeLoadType
{
	AfterSceneLoad = 0,
	BeforeSceneLoad = 1,
	AfterAssembliesLoaded = 2,
	BeforeSplashScreen = 3,
	SubsystemRegistration = 4,
}

