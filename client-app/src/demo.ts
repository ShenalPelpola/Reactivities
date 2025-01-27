export interface Duck {
    name: string;
    numLegs: number;
    makeSound: (sound: string) => void;
};

const duck1 : Duck = {
    name: "huey",
    numLegs: 2,
    makeSound: (sound: string) => console.log(sound)
};

export const ducks = [duck1];