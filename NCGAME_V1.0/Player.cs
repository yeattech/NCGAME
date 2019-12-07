﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCGAME_V1._0
{
   public class Player:AnimatedObject
    {
		private int _playerNo;
		private string _name;
		private int _hp;
		private int _mp;
		private BuffN? _buffOn;
		private int _buffEffectRound;
		private DebuffN? _debuffOn;
		private int _debuffEffectround;
		private Character _characterChosen;
		private EquippedWeapon _equipWeapon;

		public Player(int playerNo)
		{
			_playerNo = playerNo;
			_name = "";
			_hp = 0;
			_mp = 0;
		}

		public int PlayerNo
		{
			get { return _playerNo; }
			set { _playerNo = value; }
		}
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public int Hp
		{
			get { return _hp; }
			set { _hp = value; }
		}
		public int Mp
		{
			get { return _mp; }
			set { _mp = value; }
		}
		public BuffN? BuffOn
		{
			get { return _buffOn; }
			set { _buffOn = value; }
		}
		public DebuffN? DebuffOn
		{
			get { return _debuffOn; }
			set { _debuffOn = value; }
		}
		public int BuffEffectRound
		{
			get { return _buffEffectRound; }
			set { _buffEffectRound = value; }
		}
		public int DebuffEffectRound
		{
			get { return _debuffEffectround; }
			set { _debuffEffectround = value; }
		}
		public Character CharacterChosen
		{
			get { return _characterChosen; }
			set { _characterChosen = value; }
		}
		public EquippedWeapon EquipWeapon
		{
			get { return _equipWeapon; }
			set { _equipWeapon = value; }
		}
		public void ChooseCharacter()
		{
		}
		public void Attack()
		{
		}
		public void Defence()
		{
		}
		public void Move(string Direction)
		{
			if (Direction == "Up")
			{
				_y += 1;
			}
			else if (Direction == "Down")
			{
				_y -= 1;
			}
			else if (Direction == "Right")
			{
				_x += 1;
			}
			else if (Direction == "Left")
			{
				_x -= 1;
			}
		}
		public void GetBuff()
		{
		}
		public void GetDebuff()
		{
		}
		public void GetPotion()
		{
		}
		public void BuffEffect()
		{
		}
		public void DebuffEffect()
		{
		}
	}
}