using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreDevs_API;

namespace MegaTools
{
    internal class Logic
    {
		// Token: 0x0600001C RID: 28 RVA: 0x00002C24 File Offset: 0x00000E24
		public void Injectar()
		{
			Debug.WriteLine("Iniciando Exploit");
			this.api.LaunchExploit();
			bool flag = !this.api.isAPIAttached();
			if (flag)
			{
				Debug.WriteLine("API No Injectada");
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002C68 File Offset: 0x00000E68
		public bool validation()
		{
			return this.api.isAPIAttached();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002C90 File Offset: 0x00000E90
		public void Fire()
		{
			bool flag = !this.fireActive;
			if (flag)
			{
				this.api.AddFire("me");
				this.fireActive = true;
			}
			else
			{
				this.api.RemoveFire("me");
				this.fireActive = false;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002CE4 File Offset: 0x00000EE4
		public void Smoke()
		{
			bool flag = !this.smokeActive;
			if (flag)
			{
				this.api.AddSmoke("me");
				this.smokeActive = true;
			}
			else
			{
				this.api.RemoveSmoke("me");
				this.smokeActive = false;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002D38 File Offset: 0x00000F38
		public void Sparkles()
		{
			bool flag = !this.sparklesActive;
			if (flag)
			{
				this.api.AddSparkles("me");
				this.sparklesActive = true;
			}
			else
			{
				this.api.RemoveSparkles("me");
				this.sparklesActive = false;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002D8C File Offset: 0x00000F8C
		public void ForceField()
		{
			bool flag = !this.foreActive;
			if (flag)
			{
				this.api.AddForcefield("me");
				this.foreActive = true;
			}
			else
			{
				this.api.RemoveForceField("me");
				this.foreActive = false;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002DDD File Offset: 0x00000FDD
		public void TeleportToPlayer()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public void RunLuaScript(string luaScript)
		{
			this.api.SendLuaScript(luaScript);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002DF0 File Offset: 0x00000FF0
		public void tpsuper()
		{
			this.api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = 1000");
		}

		// Token: 0x04000010 RID: 16
		private bool fireActive;

		// Token: 0x04000011 RID: 17
		private bool smokeActive;

		// Token: 0x04000012 RID: 18
		private bool foreActive;

		// Token: 0x04000013 RID: 19
		private bool sparklesActive;

		// Token: 0x04000014 RID: 20
		private bool toolsActive = false;

		// Token: 0x04000015 RID: 21
		private readonly ExploitAPI api = new ExploitAPI();
	}
}

