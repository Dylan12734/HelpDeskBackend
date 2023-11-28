INSERT INTO Tickets ( CreatedDate, UpdatedDate, isActive, TicketId, Title, Description, OpenedBy, ResolvedById)
VALUES 
( '2023-11-27T08:00:00', '2023-11-27T08:15:00', 0, 1, 'Report Bug', 'Application crashes when clicking...', 'John Hop', null),
( '2023-11-26T09:30:00', '2023-11-26T10:00:00', 0, 2, 'Feature Request', 'Ability to sort items in the list...', 'Mike Blackburn', NULL),
( '2023-11-25T11:45:00', '2023-11-25T12:00:00', 0, 3, 'Login Issue', 'Users unable to log in with...', 'Duke Nukem', null);
INSERT INTO Favorites ( CreatedDate, UpdatedDate, isActive, FavoritesId, UserId, TicketId)
VALUES 
( '2023-11-27T08:00:00', '2023-11-27T08:15:00', 1, 1, 501, 1),
( '2023-11-26T09:30:00', '2023-11-26T10:00:00', 0, 2, 502, 3),
( '2023-11-25T11:45:00', '2023-11-25T12:00:00', 1, 3, 503, 2);