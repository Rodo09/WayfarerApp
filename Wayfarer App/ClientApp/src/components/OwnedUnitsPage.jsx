import * as React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableContainer from '@material-ui/core/TableContainer';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import Paper from '@material-ui/core/Paper';


export default class OwnedUnitsGrid extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            OwnedUnitsVMList: []
        }
    }

    componentDidMount() {
        this.getData();
    }

    getData = () => {
        const url = "api/Units/GetUnitVMList";
        fetch(url)
            .then(response => {
                return response.json();
            })
            .then(response => {
                this.setState({ OwnedUnitsVMList: response });
                console.log("units");
                console.log(response);
            });
    }

    render() {
        return (
            <TableContainer component={Paper}>
                <Table /*className={classes.table}*/ aria-label="simple table">
                    <TableHead>
                        <TableRow>
                            <TableCell>Portrait</TableCell>
                            <TableCell align="right">Name</TableCell>
                            <TableCell align="right">Faction</TableCell>
                            <TableCell align="right">Rarity</TableCell>
                            <TableCell align="right">Limit Break</TableCell>
                            <TableCell align="right">Awakening</TableCell>
                            <TableCell align="right">Level</TableCell>
                            <TableCell align="right">Job 1</TableCell>
                            <TableCell align="right">Job 1 Level</TableCell>
                            <TableCell align="right">Job 2</TableCell>
                            <TableCell align="right">Job 2 Level</TableCell>
                            <TableCell align="right">Job 3</TableCell>
                            <TableCell align="right">Job 3 Level</TableCell>
                        </TableRow>
                    </TableHead>
                    <TableBody>
                        {
                            this.state.OwnedUnitsVMList.map((row) => {
                                var maxlevel = 30;
                                var maxjoblvl1 = 15;
                                var maxjoblvl2 = 15;
                                var maxjoblvl3 = 15;
                                switch (row.unitLimitBreak + "|" + row.unitAwakening) {
                                    case "0|2":
                                        maxlevel = maxlevel + 5;
                                        break;
                                    case "0|3":
                                        maxlevel = maxlevel + 10;
                                        break;
                                    case "0|4":
                                        maxlevel = maxlevel + 15;
                                        break;
                                    case "0|5":
                                        maxlevel = maxlevel + 20;
                                        break;
                                    case "0|6":
                                        maxlevel = maxlevel + 34;
                                        break;
                                    case "1|1":
                                        maxlevel = maxlevel + 5;
                                        break;
                                    case "1|2":
                                        maxlevel = maxlevel + 10;
                                        break;
                                    case "1|3":
                                        maxlevel = maxlevel + 15;
                                        break;
                                    case "1|4":
                                        maxlevel = maxlevel + 20;
                                        break;
                                    case "1|5":
                                        maxlevel = maxlevel + 25;
                                        break;
                                    case "1|6":
                                        maxlevel = maxlevel + 39;
                                        break;
                                    case "2|1":
                                        maxlevel = maxlevel + 10;
                                        break;
                                    case "2|2":
                                        maxlevel = maxlevel + 15;
                                        break;
                                    case "2|3":
                                        maxlevel = maxlevel + 20;
                                        break;
                                    case "2|4":
                                        maxlevel = maxlevel + 25;
                                        break;
                                    case "2|5":
                                        maxlevel = maxlevel + 30;
                                        break;
                                    case "2|6":
                                        maxlevel = maxlevel + 44;
                                        break;
                                    case "3|1":
                                        maxlevel = maxlevel + 15;
                                        break;
                                    case "3|2":
                                        maxlevel = maxlevel + 20;
                                        break;
                                    case "3|3":
                                        maxlevel = maxlevel + 25;
                                        break;
                                    case "3|4":
                                        maxlevel = maxlevel + 30;
                                        break;
                                    case "3|5":
                                        maxlevel = maxlevel + 35;
                                        break;
                                    case "3|6":
                                        maxlevel = maxlevel + 49;
                                        break;
                                    case "4|1":
                                        maxlevel = maxlevel + 25;
                                        break;
                                    case "4|2":
                                        maxlevel = maxlevel + 30;
                                        break;
                                    case "4|3":
                                        maxlevel = maxlevel + 35;
                                        break;
                                    case "4|4":
                                        maxlevel = maxlevel + 40;
                                        break;
                                    case "4|5":
                                        maxlevel = maxlevel + 45;
                                        break;
                                    case "4|6":
                                        maxlevel = maxlevel + 59;
                                        break;
                                    case "5|1":
                                        maxlevel = maxlevel + 35;
                                        break;
                                    case "5|2":
                                        maxlevel = maxlevel + 40;
                                        break;
                                    case "5|3":
                                        maxlevel = maxlevel + 45;
                                        break;
                                    case "5|4":
                                        maxlevel = maxlevel + 50;
                                        break;
                                    case "5|5":
                                        maxlevel = maxlevel + 55;
                                        break;
                                    case "5|6":
                                        maxlevel = maxlevel + 69;
                                        break;
                                    default: maxlevel = 30;
                                }

                                return (
                                    <TableRow key={row.ownedUnitId}>
                                        <TableCell component="th" scope="row">
                                            {row.unitImage}
                                        </TableCell>
                                        <TableCell align="right">{row.name}</TableCell>
                                        <TableCell align="right">{row.faction}</TableCell>
                                        <TableCell align="right">
                                            <img src={row.rarityImage}/>
                                        </TableCell>
                                        <TableCell align="right">{row.unitLimitBreak}</TableCell>
                                        <TableCell align="right">{row.unitAwakening}</TableCell>
                                        <TableCell align="right">{row.unitLevel + "/" + maxlevel}</TableCell>
                                        <TableCell align="right">{row.job1}</TableCell>
                                        <TableCell align="right">{row.unitJob1Level + "/" + maxjoblvl1}</TableCell>
                                        <TableCell align="right">{row.job2}</TableCell>
                                        <TableCell align="right">{row.unitJob2Level == null ? "" : row.unitJob2Level + "/" + maxjoblvl2}</TableCell>
                                        <TableCell align="right">{row.job3}</TableCell>
                                        <TableCell align="right">{row.unitJob3Level == null ? "" : row.unitJob3Level + "/" + maxjoblvl3}</TableCell>
                                    </TableRow>
                                )
                            })}
                    </TableBody>
                </Table>
            </TableContainer>
        )
    }

}