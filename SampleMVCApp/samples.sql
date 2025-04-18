-- Crea la tabella Prodotti in base alla definizione del modello Prodotto.cs
CREATE TABLE Prodotti (
    Id NUMBER PRIMARY KEY,
    NomeProdotto VARCHAR2(255) NOT NULL,
    Quantita NUMBER(10,2) NOT NULL,
    Note VARCHAR2(10000)
);

-- Elettronica
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (1, 'Smartphone XYZ Pro', 25, 'Smartphone di ultima generazione con fotocamera avanzata');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (2, 'Laptop UltraBook', 15, 'Laptop leggero e potente per professionisti');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (3, 'Smart TV 55"', 10, 'TV 4K con assistente vocale integrato');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (4, 'Cuffie Wireless', 30, 'Cuffie con cancellazione del rumore');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (5, 'Tablet Pro 11', 20, 'Tablet con display retina e pennino incluso');

-- Abbigliamento
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (6, 'Giacca Invernale', 35, 'Giacca impermeabile con imbottitura termica');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (7, 'Jeans Classic', 50, 'Jeans in denim di alta qualità');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (8, 'T-Shirt Basic', 100, 'T-shirt in cotone 100% organico');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (9, 'Scarpe Sportive', 40, 'Scarpe leggere per corsa e fitness');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (10, 'Cappello Elegante', 25, 'Cappello in lana per occasioni formali');

-- Casa e Arredamento
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (11, 'Lampada da Tavolo', 30, 'Lampada moderna con illuminazione LED');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (12, 'Set Pentole', 15, 'Set di pentole antiaderenti di alta qualità');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (13, 'Divano Moderno', 8, 'Divano a 3 posti in tessuto antimacchia');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (14, 'Tappeto Persiano', 10, 'Tappeto decorativo fatto a mano');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (15, 'Libreria Componibile', 12, 'Libreria modulare in legno naturale');

-- Alimentari
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (16, 'Olio Extra Vergine', 50, 'Olio d''oliva di prima spremitura');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (17, 'Vino Rosso', 40, 'Bottiglia di vino rosso invecchiato');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (18, 'Cioccolato Artigianale', 60, 'Tavoletta di cioccolato fondente 85%');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (19, 'Pasta Italiana', 100, 'Confezione di pasta trafilata al bronzo');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (20, 'Caffè Premium', 45, 'Caffè arabica in grani tostato');

-- Sport e Tempo libero
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (21, 'Pallone da Calcio', 35, 'Pallone ufficiale da competizione');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (22, 'Racchetta da Tennis', 20, 'Racchetta professionale in carbonio');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (23, 'Tenda da Campeggio', 15, 'Tenda impermeabile per 4 persone');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (24, 'Gioco da Tavolo', 25, 'Gioco strategico per tutta la famiglia');
INSERT INTO Prodotti (Id, NomeProdotto, Quantita, Note) VALUES (25, 'Drone con Videocamera', 10, 'Drone con stabilizzatore e registrazione 4K');
