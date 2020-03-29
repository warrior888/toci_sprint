drop table VotesForCandidates;
drop table Candidates;
drop table ElectionKind;
drop table VoteUsers;
drop table Translations;
drop table Phrases;
drop table Languages;
drop table Occupations;
drop table GeographicRegions;

create table Languages
(
	Id bigint identity primary key,
	Name text,
	Currency text
);

insert into Languages (name, currency) values ('Polski', 'PLN');

create table Phrases
(
	Id bigint identity primary key,
	Phrase text
);

insert into Phrases (Phrase) values ('_welcome');

insert into Languages (name) values ('_polish');

insert into Phrases (Phrase) values ('_unknown_database_error');

create table Translations
(
	Id bigint identity primary key,
	IdLanguages bigint references Languages(Id),
	IdPhrases bigint references Phrases(Id),
	Translation text
);

create table VoteUsers
(
	Id integer identity primary key,
	ComesFrom int,
	Gender int,
	Name text,
	Surname text,
	Email text,
	Phone text,
	Password text,
	EmailVerified int,
	City text,
	PostCode text,
	Street text,
	IdLanguages bigint references Languages(Id),
	IdOccupations integer references Occupations(Id),
	IdGeographicRegions integer references GeographicRegions(Id)
);

create table ElectionKind
(
	Id integer identity primary key,
	ElectionKind text
);

create table Candidates
(
	Id integer identity primary key
);

create table VotesForCandidates
(
	Id integer identity primary key,
	IdVoteUsers integer references VoteUsers(Id),
	IdCandidates integer references Candidates(Id)
);

create table FriendVotes
(
	Id integer identity primary key,
	IdFriendsVotes integer references FriendVotes(Id),
);

create table GeographicRegions
(
	Id integer identity primary key,
	IdGeographicRegions integer references GeographicRegions(Id),
	Name text
);

create table Occupations
(
	Id integer identity primary key,
	IdOccupations integer references Occupations(Id),
	Name text
);