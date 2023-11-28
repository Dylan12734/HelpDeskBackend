
INSERT INTO Tickets ( CreatedDate, UpdatedDate, isActive, TicketId, Title, Description, OpenedById, ResolvedById)
VALUES 
( '2023-11-27T08:00:00', '2023-11-27T08:15:00', 1, 1, 'Report Bug', 'Application crashes when clicking...', 101, 201),
( '2023-11-26T09:30:00', '2023-11-26T10:00:00', 0, 2, 'Feature Request', 'Ability to sort items in the list...', 102, NULL),
( '2023-11-25T11:45:00', '2023-11-25T12:00:00', 1, 3, 'Login Issue', 'Users unable to log in with...', 103, 203);
INSERT INTO Favorites ( CreatedDate, UpdatedDate, isActive, FavoritesId, UserId, TicketId)
VALUES 
( '2023-11-27T08:00:00', '2023-11-27T08:15:00', 1, 1, 501, 1),
( '2023-11-26T09:30:00', '2023-11-26T10:00:00', 0, 2, 502, 3),
( '2023-11-25T11:45:00', '2023-11-25T12:00:00', 1, 3, 503, 2);