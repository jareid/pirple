"""
The following lines create dictionary containing metadata
about a song
""" 
SongDictionary = {"Artist": "Tupac", "Genre": "Hip-Hop", "Title": "Life Goes On", "DurationInSeconds": 301, "Album": "All Eyez On Me", "AlbumArtist": "Tupac", "FileSizeMB": 11.5, "Year": 2001, "Rating": 4.5}

for MetaData in SongDictionary:
	print(MetaData + ":" + str(SongDictionary[MetaData]));


