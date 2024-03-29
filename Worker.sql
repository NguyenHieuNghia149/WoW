INSERT INTO [dbo].[Worker] ([ID], [UserName], [Password], [Email], [Location], [PhoneNumber], [Job], [Price], [Experience], [IDcard], [imageIDcardFront], [imageIDcardBack], [AccountBalance], [Report])
VALUES 
(1, 'worker1', 'pass1', 'worker1@example.com', 'Location1', '123456789', 'Clean Toilet', 50, 5, 'ID123', NULL, NULL, 100, 1),
(2, 'worker2', 'pass2', 'worker2@example.com', 'Location2', '987654321', 'Clean Floor', 60, 7, 'ID456', NULL, NULL, 150, 2),
(3, 'worker3', 'pass3', 'worker3@example.com', 'Location3', '654987321', 'Electrical repair', 70, 8, 'ID789', NULL, NULL, 200, 1),
(4, 'worker4', 'pass4', 'worker4@example.com', 'Location4', '321654987', 'Plumbing repair', 80, 6, 'ID321', NULL, NULL, 120, 3),
(5, 'worker5', 'pass5', 'worker5@example.com', 'Location5', '789123654', 'Install system', 90, 9, 'ID654', NULL, NULL, 180, 5);
