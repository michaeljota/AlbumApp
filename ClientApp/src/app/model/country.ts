export class Country {
  id: number;
  name: string;

  constructor(country: Partial<Country>) {
    Object.assign(this, country);
  }
}
