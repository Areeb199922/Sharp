﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToSQLMusic
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Music")]
	public partial class PlaylistDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSong(Song instance);
    partial void UpdateSong(Song instance);
    partial void DeleteSong(Song instance);
    #endregion
		
		public PlaylistDataContext() : 
				base(global::LinqToSQLMusic.Properties.Settings.Default.MusicConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PlaylistDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PlaylistDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PlaylistDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PlaylistDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Song> Songs
		{
			get
			{
				return this.GetTable<Song>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Songs")]
	public partial class Song : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SerialNum;
		
		private string _SongName;
		
		private string _ArtistName;
		
		private System.Nullable<System.DateTime> _ReleaseDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSerialNumChanging(int value);
    partial void OnSerialNumChanged();
    partial void OnSongNameChanging(string value);
    partial void OnSongNameChanged();
    partial void OnArtistNameChanging(string value);
    partial void OnArtistNameChanged();
    partial void OnReleaseDateChanging(System.Nullable<System.DateTime> value);
    partial void OnReleaseDateChanged();
    #endregion
		
		public Song()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SerialNum", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SerialNum
		{
			get
			{
				return this._SerialNum;
			}
			set
			{
				if ((this._SerialNum != value))
				{
					this.OnSerialNumChanging(value);
					this.SendPropertyChanging();
					this._SerialNum = value;
					this.SendPropertyChanged("SerialNum");
					this.OnSerialNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SongName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SongName
		{
			get
			{
				return this._SongName;
			}
			set
			{
				if ((this._SongName != value))
				{
					this.OnSongNameChanging(value);
					this.SendPropertyChanging();
					this._SongName = value;
					this.SendPropertyChanged("SongName");
					this.OnSongNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArtistName", DbType="NVarChar(50)")]
		public string ArtistName
		{
			get
			{
				return this._ArtistName;
			}
			set
			{
				if ((this._ArtistName != value))
				{
					this.OnArtistNameChanging(value);
					this.SendPropertyChanging();
					this._ArtistName = value;
					this.SendPropertyChanged("ArtistName");
					this.OnArtistNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReleaseDate", DbType="Date")]
		public System.Nullable<System.DateTime> ReleaseDate
		{
			get
			{
				return this._ReleaseDate;
			}
			set
			{
				if ((this._ReleaseDate != value))
				{
					this.OnReleaseDateChanging(value);
					this.SendPropertyChanging();
					this._ReleaseDate = value;
					this.SendPropertyChanged("ReleaseDate");
					this.OnReleaseDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
