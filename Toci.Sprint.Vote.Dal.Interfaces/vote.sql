drop table VotesForCandidates;
drop table Candidates;
drop table VoteUsers;

create table VoteUsers
(
	Id integer identity primary key
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