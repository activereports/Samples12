Imports System.IO
Imports GrapeCity.ActiveReports.Extensibility.Rendering.Components.Map
Namespace GrapeCity.ActiveReports.Samples.CustomTileProviders
	''' <summary>
	''' Represents single map tile.
	''' </summary>
	Friend NotInheritable Class MapTile
		Implements IMapTile
		''' <summary>
		''' Initializes new instance of <see cref="MapTile"/>
		''' </summary>
		Public Sub New(id As MapTileKey, imageStream As Stream)
			_id = id
			_image = imageStream
		End Sub
		''' <summary>
		''' Gets the tile identifier
		''' </summary>
		''' 
		Public ReadOnly Property Id() As MapTileKey Implements IMapTile.Id
			Get
				Return _id
			End Get
		End Property
		Private _id As MapTileKey
		''' <summary>
		''' Gets the tile image stream.
		''' </summary>
		Public ReadOnly Property Image() As Stream Implements IMapTile.Image
			Get
				Return _image
			End Get
		End Property
		Private _image As Stream
	End Class
End Namespace
