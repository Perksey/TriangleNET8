#if !__IOS__ && !__ANDROID__
Triangle.Program.Run();
#elif __IOS__
using Silk.NET.Input.Sdl;
using Silk.NET.Windowing;
SdlInput.RegisterPlatform();
Triangle.Program.API = new GraphicsAPI(ContextAPI.OpenGLES, ContextProfile.Core, ContextFlags.Default, new APIVersion(3, 0));
Triangle.Program.Run();
#endif
