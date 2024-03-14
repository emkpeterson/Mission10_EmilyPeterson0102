import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlerList() {
  const [BowlerData, setBowlerData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const bowlerResponse = await fetch(
        'http://localhost:5062/Bowling/bowlers',
      );
      const teamResponse = await fetch('http://localhost:5062/Bowling/teams');
      const bowlerData = await bowlerResponse.json();
      const teamData = await teamResponse.json();

      // Join bowlerData with teamData based on teamID
      const bowlerWithTeamData = bowlerData.map((b: { teamID: any }) => {
        const team = teamData.find(
          (t: { teamID: any }) => t.teamID === b.teamID,
        );
        return { ...b, teamName: team ? team.teamName : 'Unknown Team' };
      });

      setBowlerData(bowlerWithTeamData);
    };

    fetchBowlerData();
  }, []);

  return (
    <>
      <br />
      <div className="row">
        <br></br>
        <h4 className="text-center">Bowler Information</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {BowlerData.filter(
            (b) => b.teamName === 'Marlins' || b.teamName === 'Sharks',
          ) // Filter bowlers by team name
            .map((b) => (
              <tr key={b.bowlerID}>
                <td>
                  {b.bowlerMiddleInit
                    ? `${b.bowlerFirstName} ${b.bowlerMiddleInit}. ${b.bowlerLastName}`
                    : `${b.bowlerFirstName} ${b.bowlerLastName}`}
                </td>
                <td>{b.teamName}</td>
                <td>{b.bowlerAddress}</td>
                <td>{b.bowlerCity}</td>
                <td>{b.bowlerState}</td>
                <td>{b.bowlerZip}</td>
                <td>{b.bowlerPhoneNumber}</td>
              </tr>
            ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
