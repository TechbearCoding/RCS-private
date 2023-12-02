SELECT artists.Name, albums.Title, tracks.Name
FROM artists
INNER JOIN albums
ON artists.ArtistId = albums.ArtistId
INNER JOIN tracks
ON albums.AlbumId = tracks.AlbumId
WHERE albums.Title = 'Volume Dois'
ORDER BY tracks.Name desc;

SELECT artists.Name, albums.Title, tracks.Name
FROM artists
INNER JOIN albums
ON artists.ArtistId = albums.ArtistId
INNER JOIN tracks
ON albums.AlbumId = tracks.AlbumId
ORDER BY tracks.Name asc;