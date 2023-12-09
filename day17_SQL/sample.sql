SELECT playlists.PlaylistId, tracks.Name, playlists.Name
FROM tracks
INNER JOIN playlist_track
ON tracks.TrackId = playlist_track.TrackId
INNER JOIN playlists
ON playlist_track.PlaylistId = playlists.PlaylistId
WHERE playlists.PlaylistId = 1;


SELECT (customers.firstName || ' ' || customers.LastName) as 'Client name',
tracks.Name
FROM customers
INNER JOIN invoices
ON customers.CustomerId = invoices.CustomerId
INNER JOIN invoice_items
ON invoices.InvoiceId = invoice_items.InvoiceId
INNER JOIN tracks
ON tracks.TrackId = invoice_items.TrackId
WHERE customers.CustomerId = 4;


SELECT COUNT(customers.CustomerId) as 'Klientu skaits'
FROM customers;

SELECT tracks.Name, MAX(tracks.Milliseconds)
FROM tracks;

SELECT customers.CustomerId, (customers.firstName || ' ' || customers.LastName) as 'Client name',
COUNT(tracks.TrackId) as 'Dziesmu skaits'
FROM customers
INNER JOIN invoices
ON customers.CustomerId = invoices.CustomerId
INNER JOIN invoice_items
ON invoices.InvoiceId = invoice_items.InvoiceId
INNER JOIN tracks
ON tracks.TrackId = invoice_items.TrackId
GROUP BY customers.CustomerId;


SELECT playlists.Name,
sum (tracks.Milliseconds) as ' Playlist sum'
FROM tracks
INNER JOIN playlist_track
ON playlist_track.TrackId = tracks.TrackId
INNER JOIN playlists
ON playlists.PlaylistId = playlist_track.PlaylistId
GROUP BY playlists.PlaylistId;



