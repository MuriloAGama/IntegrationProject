﻿using System.ComponentModel.DataAnnotations;
using Greeniverse.src.utils;

namespace Greeniverse.src.DTOS
{
    /// <summary>
    /// <para>abstract: Mirror Class for create a new user</para>
    /// <para>Version: 1.0</para>
    /// <para>Date: 13/05/2022</para>
    /// </summary>

    public class NewUserDTO
    {
        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(30)]
        public string Email { get; set; }

        [Required, StringLength(30)]
        public string Password { get; set; }

        [Required, StringLength(50)]
        public string Address { get; set; }

        [Required, StringLength(30)]
        public string Phone { get; set; }

        [Required]
        public UserType UserType { get; set; }

        [Required]
        public uint WalletCoins { get; set; }

        public NewUserDTO(string name, string email, string password, string address, string phone, UserType userType, uint walletCoins)
        {
            Name = name;
            Email = email;
            Password = password;
            Address = address;
            Phone = phone;
            UserType = userType;
            WalletCoins = walletCoins;
        }
    }
    /// <summary>
    /// <para>abstract: Mirror Class for change a new user</para>
    /// <para>Version: 1.0</para>
    /// <para>Date: 05/13/2022</para>
    /// </summary>

    public class UpdateUserDTO
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(30)]
        public string Email { get; set; }

        [Required, StringLength(30)]
        public string Password { get; set; }

        [Required, StringLength(50)]
        public string Address { get; set; }

        [Required, StringLength(15)]
        public string Phone { get; set; }

        [Required]
        public UserType UserType { get; set; }

        [Required]
        public uint WalletCoins { get; set; }

        public UpdateUserDTO(string name, string email, string password, string address, string phone, UserType userType, uint walletCoins)
        {
            Name = name;
            Email = email;
            Password = password;
            Address = address;
            Phone = phone;
            UserType = userType;
            WalletCoins = walletCoins;
        }
    }
}
