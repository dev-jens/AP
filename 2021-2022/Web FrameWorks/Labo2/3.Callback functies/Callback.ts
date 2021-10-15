function GSM(jaar:number,klantNr:number,bestelNr:number)
{
    let arrJaar = [0,0,0]
    let arrKlant = [0,0,0,0]
    let arrBestelNr = [0,0,0]

    for (let i = 0; i < `${jaar}`.length; i++)
    {
        arrJaar[arrJaar.length-1-i]  = parseInt(`${jaar}`[`${jaar}`.length - 1-i])
    }
    for (let i = 0; i < `${klantNr}`.length; i++)
    {
        arrKlant[arrKlant.length-1-i]  = parseInt(`${klantNr}`[`${klantNr}`.length - 1-i])
    }
    for (let i = 0; i <`${bestelNr}`.length; i++)
    {
        arrBestelNr[arrBestelNr.length-1-i]  = parseInt(`${bestelNr}`[`${bestelNr}`.length - 1-i])
    }
    let checksum = parseInt(`${arrJaar.join('')}${arrKlant.join('')}${arrBestelNr.join('')}`) % 97
return `+++${arrJaar.join('')}/${arrKlant.join('')}/${arrBestelNr.join('')}${checksum}+++`

}