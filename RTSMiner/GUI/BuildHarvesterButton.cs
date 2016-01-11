﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RTSMiner.Helpers;
using RTSMiner.Units;
using VoidEngine.VGUI;

namespace RTSMiner.GUI
{
	class BuildHarvesterButton : Button
	{
		Unit Unit;
		Game1 myGame;

		public BuildHarvesterButton(Vector2 Position, Texture2D texture, SpriteFont font, Unit unit)
			: base(texture, Position, font, 1.0f, Color.Black, "Harvest Wood", Color.White)
		{
			AddAnimations(texture);
			Unit = unit;
		}

		public override void Update(GameTime gameTime)
		{
			if (this.Clicked() && !Unit.LockUnit)
			{
				if (myGame.gameManager.UraniumStored >= 10)
				{
					myGame.gameManager.UraniumStored -= 10;
					Unit.MaterialsCount = 0;
				}

				Unit.currentBehaviors = RTSHelper.UnitBehaviors.HarvestUranium;
			}

			base.Update(gameTime);
		}

		public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
		{
			base.Draw(gameTime, spriteBatch);
		}

		protected override void AddAnimations(Texture2D texture)
		{
			base.AddAnimations(texture);
		}
	}
}
