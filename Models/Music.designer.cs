﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc.Models
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


	[System.Data.Linq.Mapping.DatabaseAttribute(Name="MusicCatalog")]
	public partial class MusicDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertArtist(Artist instance);
    partial void UpdateArtist(Artist instance);
    partial void DeleteArtist(Artist instance);
    partial void InsertAlbum(Album instance);
    partial void UpdateAlbum(Album instance);
    partial void DeleteAlbum(Album instance);
    partial void InsertSong(Song instance);
    partial void UpdateSong(Song instance);
    partial void DeleteSong(Song instance);
    #endregion
		
		public MusicDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MusicCatalogConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MusicDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MusicDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MusicDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MusicDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Artist> Artists
		{
			get
			{
				return this.GetTable<Artist>();
			}
		}
		
		public System.Data.Linq.Table<Album> Albums
		{
			get
			{
				return this.GetTable<Album>();
			}
		}
		
		public System.Data.Linq.Table<Song> Songs
		{
			get
			{
				return this.GetTable<Song>();
			}
		}
	}
	
	[Table(Name="dbo.Artist")]
	public partial class Artist : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private EntitySet<Album> _Albums;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public Artist()
		{
			this._Albums = new EntitySet<Album>(new Action<Album>(this.attach_Albums), new Action<Album>(this.detach_Albums));
			OnCreated();
		}
		
		[Column(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[Column(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[Association(Name="Artist_Album", Storage="_Albums", OtherKey="artist_id")]
		public EntitySet<Album> Albums
		{
			get
			{
				return this._Albums;
			}
			set
			{
				this._Albums.Assign(value);
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
		
		private void attach_Albums(Album entity)
		{
			this.SendPropertyChanging();
			entity.Artist = this;
		}
		
		private void detach_Albums(Album entity)
		{
			this.SendPropertyChanging();
			entity.Artist = null;
		}
	}
	
	[Table(Name="dbo.Album")]
	public partial class Album : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _artist_id;
		
		private string _name;
		
		private EntitySet<Song> _Songs;
		
		private EntityRef<Artist> _Artist;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onartist_idChanging(int value);
    partial void Onartist_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public Album()
		{
			this._Songs = new EntitySet<Song>(new Action<Song>(this.attach_Songs), new Action<Song>(this.detach_Songs));
			this._Artist = default(EntityRef<Artist>);
			OnCreated();
		}
		
		[Column(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[Column(Storage="_artist_id", DbType="Int NOT NULL")]
		public int artist_id
		{
			get
			{
				return this._artist_id;
			}
			set
			{
				if ((this._artist_id != value))
				{
					if (this._Artist.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onartist_idChanging(value);
					this.SendPropertyChanging();
					this._artist_id = value;
					this.SendPropertyChanged("artist_id");
					this.Onartist_idChanged();
				}
			}
		}
		
		[Column(Storage="_name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[Association(Name="Album_Song", Storage="_Songs", OtherKey="album_id")]
		public EntitySet<Song> Songs
		{
			get
			{
				return this._Songs;
			}
			set
			{
				this._Songs.Assign(value);
			}
		}
		
		[Association(Name="Artist_Album", Storage="_Artist", ThisKey="artist_id", IsForeignKey=true)]
		public Artist Artist
		{
			get
			{
				return this._Artist.Entity;
			}
			set
			{
				Artist previousValue = this._Artist.Entity;
				if (((previousValue != value) 
							|| (this._Artist.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Artist.Entity = null;
						previousValue.Albums.Remove(this);
					}
					this._Artist.Entity = value;
					if ((value != null))
					{
						value.Albums.Add(this);
						this._artist_id = value.id;
					}
					else
					{
						this._artist_id = default(int);
					}
					this.SendPropertyChanged("Artist");
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
		
		private void attach_Songs(Song entity)
		{
			this.SendPropertyChanging();
			entity.Album = this;
		}
		
		private void detach_Songs(Song entity)
		{
			this.SendPropertyChanging();
			entity.Album = null;
		}
	}
	
	[Table(Name="dbo.Song")]
	public partial class Song : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private int _album_id;
		
		private EntityRef<Album> _Album;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void Onalbum_idChanging(int value);
    partial void Onalbum_idChanged();
    #endregion
		
		public Song()
		{
			this._Album = default(EntityRef<Album>);
			OnCreated();
		}
		
		[Column(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[Column(Storage="_name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[Column(Storage="_album_id", DbType="Int NOT NULL")]
		public int album_id
		{
			get
			{
				return this._album_id;
			}
			set
			{
				if ((this._album_id != value))
				{
					if (this._Album.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onalbum_idChanging(value);
					this.SendPropertyChanging();
					this._album_id = value;
					this.SendPropertyChanged("album_id");
					this.Onalbum_idChanged();
				}
			}
		}
		
		[Association(Name="Album_Song", Storage="_Album", ThisKey="album_id", IsForeignKey=true)]
		public Album Album
		{
			get
			{
				return this._Album.Entity;
			}
			set
			{
				Album previousValue = this._Album.Entity;
				if (((previousValue != value) 
							|| (this._Album.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Album.Entity = null;
						previousValue.Songs.Remove(this);
					}
					this._Album.Entity = value;
					if ((value != null))
					{
						value.Songs.Add(this);
						this._album_id = value.id;
					}
					else
					{
						this._album_id = default(int);
					}
					this.SendPropertyChanged("Album");
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